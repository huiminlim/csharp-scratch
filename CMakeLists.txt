# C# scratchpad codes
project( csharp-scratchpad LANGUAGES CSharp )

cmake_minimum_required( VERSION 3.21 )

# Create basic app
add_executable( basic basics/main.cs )
set_property( TARGET basic PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.7.2" )
set_property( TARGET basic PROPERTY VS_DOTNET_REFERENCES
              "Microsoft.CSharp"
              "System"
              "System.Core"
              "System.Data"
)
