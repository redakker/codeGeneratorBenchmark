using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializerObjects
{
    public class House
    {
        public string Address { get; set; } = "123 Main Street, Suburbia, USA";
        public string[] Rooms { get; set; } = { "Living Room", "Kitchen", "Bedroom", "Bathroom", "Study", "Guest Room", "Basement", "Attic", "Dining Room", "Playroom" };
        public int Floors { get; set; } = 2;
        public bool HasGarden { get; set; } = true;
        public string GardenDescription { get; set; } = "The garden is well-maintained with colorful flowers, lush greenery, and a serene pond.";
        public string ExteriorColor { get; set; } = "Beige";
        public string InteriorStyle { get; set; } = "Modern Contemporary";
        public double Area { get; set; } = 250.5;
        public bool HasGarage { get; set; } = true;
        public string GarageType { get; set; } = "Attached Garage";
        public string[] Amenities { get; set; } = { "Swimming Pool", "Home Theater", "Gym", "Sauna", "Jacuzzi", "Fireplace", "Home Office", "Wine Cellar", "Game Room", "Laundry Room" };
        public int Bathrooms { get; set; } = 3;
        public int Bedrooms { get; set; } = 4;
        public bool HasFireplace { get; set; } = true;
        public string[] NearbyFacilities { get; set; } = { "Schools", "Parks", "Hospitals", "Supermarkets", "Restaurants", "Shopping Malls", "Public Transportation", "Golf Courses", "Libraries", "Fitness Centers" };
        public bool HasSecuritySystem { get; set; } = true;
        public string SecurityDescription { get; set; } = "The house is equipped with a state-of-the-art security system, including surveillance cameras, motion sensors, and alarm systems.";
        public string[] HouseRules { get; set; } = { "No smoking indoors", "No loud parties after 10 PM", "Pets must be kept on a leash in the garden", "Guests must be accompanied by residents", "No unauthorized alterations to the property", "Garbage should be disposed of properly", "Lights should be turned off when not in use", "Regular maintenance of garden required", "Shared spaces to be kept clean and tidy", "Respect neighbors' privacy and peace" };
        public string[] FavoriteSpots { get; set; } = { "Backyard patio", "Reading nook by the window", "Cozy fireplace corner", "Gourmet kitchen island", "Master bedroom balcony", "Home theater room", "Poolside lounge area", "Garden gazebo", "Fitness room with a view", "Outdoor BBQ area" };
        public bool HasSmartHomeFeatures { get; set; } = true;
        public string SmartHomeDescription { get; set; } = "The house is equipped with smart home technology, allowing residents to control lighting, temperature, security, and entertainment systems remotely.";
        public bool IsFurnished { get; set; } = true;
        public string FurnishingDescription { get; set; } = "The house comes fully furnished with high-quality furniture and appliances, offering both comfort and style.";
        public string ArchitecturalStyle { get; set; } = "Contemporary";
        public string YearBuilt { get; set; } = "2010";
        public bool HasAirConditioning { get; set; } = true;
        public bool HasHeatingSystem { get; set; } = true;
    }

}
