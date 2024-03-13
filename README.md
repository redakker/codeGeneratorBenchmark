This repo contains a proof of concept which has a benchmark for JSON serializer/deserializer.

It compares the running time an object serialization which can be run in two ways.

- serialization/deserialization with a native JsonSerializable (Reflection)
- serialization/deserialization with code generator

The relatively big Person object in this example is initialized with different kind of data.

Constants.cs contains how much people do you want to generate and (de)serialize.

This console app opens a CMD window which shows the benchmark results in the end of runtime.

Load it into Visual Studio and then start PersonSerializer in release mode.

You probably need to install the necesarry Benchmark NuGet packages

˘˘˘
# Result of one measurement

| Method             | Mean     | Error    | StdDev    | Median   |
|------------------- |---------:|---------:|----------:|---------:|
| StartReflection    | 48.51 ms | 4.317 ms | 12.729 ms | 48.95 ms |
| StartCodeGenerated | 32.35 ms | 2.452 ms |  7.231 ms | 28.43 ms |
˘˘˘
