# C# scratchpad codes
project( csharp-scratchpad LANGUAGES CSharp )

cmake_minimum_required( VERSION 3.21 )

# Set C# language version to C# 10
set( CMAKE_CSharp_FLAGS "/langversion:10" )

# Create basic app
add_executable( basic basics/main.cs )
set_property( TARGET basic PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8" )
set_property( TARGET basic PROPERTY VS_DOTNET_REFERENCES
              "Microsoft.CSharp"
              "System"
              "System.Core"
              "System.Data"
)

# Create unit testing app
add_executable( unittest unit-testing/test.cs unit-testing/code.cs )
set_property( TARGET basic PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8" )
set_property( TARGET basic PROPERTY VS_DOTNET_REFERENCES
              "Microsoft.CSharp"
              "System"
              "System.Core"
              "System.Data"
)

# Create OOP app
add_executable( oop oop/main.cs )
set_property( TARGET basic PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.8" )
set_property( TARGET basic PROPERTY VS_DOTNET_REFERENCES
              "Microsoft.CSharp"
              "System"
              "System.Core"
              "System.Data"
)
