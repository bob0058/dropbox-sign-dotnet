#!/usr/bin/env bash

# see https://github.com/OpenAPITools/openapi-generator/tree/f06e7c52f4aee6e6c53fe129e5f4f07161dcc660/modules/openapi-generator/src/main/resources/csharp-netcore

set -e

WORKINGDIR="/app/csharp"

docker run --rm \
  -v "${PWD}/:/local" \
  openapitools/openapi-generator-cli:v5.3.0 generate \
    -i "/local/oas/openapi-sdk.yaml" \
    -c "/local/openapi-config.yaml" \
    -t "/local/templates" \
    -o "/local/"

printf "\nInstalling composer dependencies ...\n"
mkdir -p "${PWD}/vendor"
bash "${PWD}/bin/php" composer install
printf "\n"

printf "Adding examples to /examples ...\n"
rm -f "${PWD}/examples/"*.cs
cp -r "${PWD}/oas/examples/"*.cs "${PWD}/examples/"

printf "Adding examples to Docs ...\n"
bash "${PWD}/bin/php" ./bin/generate-examples.php

printf "Running tests ...\n"
bash "${PWD}/bin/dotnet" dotnet test src/Org.HelloSign.Test/

printf "Success!\n"
