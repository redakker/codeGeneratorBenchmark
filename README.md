This repo contains a proof of concept which has a benchmark for JSON serializer/deserializer.

It compares the running time an object serialization which can be run in two ways.

- serialization/deserialization with a native JsonSerializable (Reflection)
- serialization/deserialization with code generator

The relatively big Person object in this example is initialized with different kind of data.

Constants.cs contains how much people do you want to generate and (de)serialize.

This console app opens a CMD window which shows the benchmark results in the end of runtime.

Load it into Visual Studio and then start PersonSerializer in release mode.

You probably need to install the necesarry Benchmark NuGet packages
