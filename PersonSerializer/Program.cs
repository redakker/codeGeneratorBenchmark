using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ReflectionSerializer;
using SerializerObjects;
using System.Text.Json;

namespace ProjectTwo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PeopleSerializer>();
        }
    }
}