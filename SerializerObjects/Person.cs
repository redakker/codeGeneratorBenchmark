using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializerObjects
{
    public class Person
    {
        public string Name { get; set; } = "John Smith is a versatile individual with a knack for problem-solving and creativity, possessing a wealth of knowledge in various domains.";
        public int Age { get; set; } = 30;
        public string Address { get; set; } = "123 Main Street, Anytown, USA. John's residence is a cozy abode adorned with family memorabilia and modern comforts.";
        public string PhoneNumber { get; set; } = "+1 (123) 456-7890";
        public string Email { get; set; } = "john.smith@example.com";
        public DateTime BirthDate { get; set; } = new DateTime(1992, 5, 10);
        public string[] Hobbies { get; set; } = { "Playing guitar", "Reading novels", "Hiking in nature" };
        public string[] Languages { get; set; } = { "English", "Spanish", "French" };
        public string Occupation { get; set; } = "Software Engineer at XYZ Corp., contributing to cutting-edge projects and fostering innovation within the team.";
        public bool IsMarried { get; set; } = true;
        public string Nationality { get; set; } = "American";
        public double Height { get; set; } = 180.5;
        public double Weight { get; set; } = 75.3;
        public bool HasDriverLicense { get; set; } = true;
        public bool IsEmployed { get; set; } = true;
        public string MotherName { get; set; } = "Mary Smith is a loving and caring mother who has been a guiding light in John's life.";
        public string FatherName { get; set; } = "David Smith is a hardworking father who instilled strong values of integrity and perseverance in John.";
        public string EmergencyContact { get; set; } = "Jane Smith, John's sister, is his trusted emergency contact, always ready to assist in times of need.";
        public string FavoriteFood { get; set; } = "Pizza with extra cheese and pepperoni is John's ultimate comfort food, enjoyed on lazy Sunday evenings.";
        public string FavoriteMovie { get; set; } = "The Shawshank Redemption holds a special place in John's heart, with its timeless themes of hope and redemption.";
        public string FavoriteQuote { get; set; } = "\"Success is not final, failure is not fatal: It is the courage to continue that counts.\" - Winston Churchill";
        public string PetName { get; set; } = "Buddy, John's loyal Labrador retriever, is his faithful companion on outdoor adventures.";
        public string DreamVacation { get; set; } = "Exploring the breathtaking landscapes of New Zealand is John's dream vacation, with its majestic mountains and pristine lakes.";
        public string ChildhoodMemory { get; set; } = "Building forts out of blankets and pillows in the living room, John and his siblings embarked on imaginary adventures that sparked creativity and camaraderie.";
        public string ChildhoodDream { get; set; } = "From an early age, John dreamed of exploring the cosmos as an astronaut, fascinated by the mysteries of the universe.";
        public string FirstLove { get; set; } = "Sarah, John's high school sweetheart, was his first love, and their innocent romance blossomed amidst laughter and shared dreams.";
        public string CareerGoal { get; set; } = "To become a leader in the field of technology, John aspires to innovate solutions that positively impact society and empower future generations.";
        public string Motto { get; set; } = "Carpe diem - seize the day. John lives by this motto, embracing each moment with passion, purpose, and gratitude.";
        public string RoleModel { get; set; } = "Elon Musk, with his visionary approach to entrepreneurship and commitment to pushing the boundaries of innovation, serves as a role model for John.";
        public string FavoriteBook { get; set; } = "The Hitchhiker's Guide to the Galaxy by Douglas Adams is a timeless classic that never fails to tickle John's funny bone.";
        public string FavoriteSong { get; set; } = "Bohemian Rhapsody by Queen is John's go-to anthem for belting out lyrics with unbridled enthusiasm.";
        public string ClosestFriend { get; set; } = "Michael, John's childhood friend, shares a bond forged through shared experiences and mutual trust.";
        public string GreatestAchievement { get; set; } = "Completing a marathon after months of rigorous training stands as one of John's greatest achievements, showcasing his determination and perseverance.";
        public string BiggestFear { get; set; } = "The fear of failure looms large in John's mind, driving him to constantly strive for excellence in all endeavors.";
        public string PersonalStrength { get; set; } = "John's resilience in the face of adversity is his greatest personal strength, enabling him to overcome obstacles with grace and determination.";
        public string PersonalWeakness { get; set; } = "Procrastination is John's Achilles' heel, often causing delays in completing tasks despite his best intentions.";
        public string MostEmbarrassingMoment { get; set; } = "Tripping and spilling coffee on his shirt during a job interview ranks as John's most embarrassing moment, leaving him red-faced and flustered.";
        public string ProudestMoment { get; set; } = "Graduating with honors from university stands as John's proudest moment, a testament to his hard work and dedication.";
        public string LifeGoal { get; set; } = "To leave a positive impact on the world and inspire others to pursue their dreams is John's ultimate life goal, driving him to make a difference every day.";
        public string FavoriteColor { get; set; } = "Blue, with its calming and serene hues, is John's favorite color, evoking feelings of tranquility and peace.";
        public string FavoriteSport { get; set; } = "Basketball, with its fast-paced action and team dynamics, is John's favorite sport, enjoyed both as a player and spectator.";
        public string FavoriteSeason { get; set; } = "Autumn, with its vibrant foliage and crisp air, is John's favorite season, signaling a time of reflection and renewal.";
        public string FavoriteAnimal { get; set; } = "Dogs hold a special place in John's heart, with their unwavering loyalty and affectionate nature.";
        public string DailyRoutine { get; set; } = "Starting the day with a cup of coffee and a morning run, John follows a structured daily routine that balances work, exercise, and relaxation.";
        public Car OwnedCar { get; set; } = new();
        public House House { get; set; } = new();

        public string toStringWithReflection()
        {
            return JsonSerializer.Serialize(this);
        }

        public Person deSerializeWithReflection(string json)
        {
            Person p =  JsonSerializer.Deserialize<Person>(json);
            return p;
        }

        public Person deSerializeWithGeneratedCode(string json)
        {
            Person p = JsonSerializer.Deserialize(json, PersonGeneratedContext.Default.Person);
            return p;
        }

        public string toStringWithGeneratedCode()
        {
            return JsonSerializer.Serialize(this, PersonGeneratedContext.Default.Person);
        }
    }

    

    [JsonSerializable(typeof(Person))]
    internal partial class PersonGeneratedContext : JsonSerializerContext
    {
    }
}
