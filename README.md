## Overview

This repository contains .NET templates designed to streamline development workflows. These templates include, but are not limited to, a migration class template for [Core.Arango.Migration](https://github.com/coronabytes/dotnet-arangodb-extensions). Core.Arango.Migration is a library that simplifies database migrations for ArangoDB in .NET applications.

## Getting Started

To use these templates, ensure you have the .NET SDK installed on your machine. You can install the templates globally using the following command:

```bash
dotnet new install <path-to-templates>
```

Once installed, you can create a new project or file using the templates. For example, to create a migration class for Core.Arango.Migration, run:

```bash
dotnet new create core.arango-migration -n MyMigration
```

This will generate a migration class named `MyMigration` in your project.

## Templates Included

- **Core.Arango Migration Class**: A template for creating migration classes compatible with Core.Arango.Migration.
- Additional templates for other use cases (coming soon).

## Learn More

For more information about Core.Arango.Migration, visit the [official GitHub repository](https://github.com/coronabytes/dotnet-arangodb-extensions).

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests to improve the templates.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.