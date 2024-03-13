using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ProjectTwo;
using SerializerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReflectionSerializer
{
    public class PeopleSerializer
    {
        [Benchmark]
        public void StartReflection()
        {
            List<Person> people = new();

            for (int i = 0; i < Constants.amountOfPerson; i++)
            {
                people.Add(new Person());
            }

            foreach (Person person in people)
            {
                string json = person.toStringWithReflection();
                Person p = person.deSerializeWithReflection(json);
            }
        }

        [Benchmark]
        public void StartCodeGenerated()
        {
            List<Person> people = new();

            for (int i = 0; i < Constants.amountOfPerson; i++)
            {
                people.Add(new Person());
            }

            foreach (Person person in people)
            {
                string json = person.toStringWithGeneratedCode();
                Person p = person.deSerializeWithGeneratedCode(json);
            }
        }
    }
}
