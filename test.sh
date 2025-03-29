#!/bin/bash
WORKING_DIR=/workspaces/dotnet-templates
templates=("core.arango-migration")
for template in "${templates[@]}"; do
  echo "Testing template: $template"
  dotnet-template-authoring verify $template -p ${WORKING_DIR} --template-args "--name Unnamed --output ${WORKING_DIR}/out/$template"
  if [ $? -ne 0 ]; then
    echo "Failed to create template $template"
    exit 1
  fi
  echo "Successfully created template $template"
done
