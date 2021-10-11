# Template project for .Net console demo applications with menu

# Specifications

- .Net version - .Net 5
- Nugets referenced
	- DotNet.Helpers
	- easyconsolestd
	- Microsoft.Extensions.Hosting

# Dependency injection

- Supported. Refer the [Program.cs](/src/Program.cs) file for more details
- The options are injected as dependency to the [MenuService](/src/MenuService.cs then those are invoked based on selection. 
