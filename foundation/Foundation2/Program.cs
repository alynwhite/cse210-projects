using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Address a1 = new Address();
        CreateAddress(a1);

        Address a2 = new Address();
        CreateAddress(a2);

        Customer c1 = new Customer(a1);
        CreateCustomer(c1);

        Customer c2 = new Customer(a2);
        CreateCustomer(c2);

        for(int i = 0; i < 3; i++){
            Order o1 = new Order(c1);
            for(int x = 0; x < 4; i++){
                Product p1 = new Product();
                CreateProduct(p1);
                o1.AddToProduct(p1);
            }
            Console.WriteLine($"total Cost: ${o1.CalculateTotalCost()}");
            Console.WriteLine($"Packing Label: {o1.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label: {o1.GetShippingLabel()}");
        }
        


    }

    static void CreateProduct(Product p1){
        List<string> productNames = new List<string>{"SnuggleJuice", "ZapFluff", "MellowBites", "SizzlePop", "GlowBrew", "ChillWave", "TurboSuds", "CrunchCloud", "BlissDrift", "FlickerGlow", "VelociTots", "DreamCrush", "SpicyWhirl", "LushLoom", "HyperDrift", "FluffZing", "PulsePops", "BlazeBite", "FrostWhisk", "PuffDash"};

        List<string> productID = new List<string>{"PDX-8743", "VLR-2195", "QBT-3201", "MZG-4532", "LXP-7840", "FGH-1293", "TBN-5820", "JRY-9034", "KPL-6712", "VTR-8416", "XFD-5318", "YJW-6427", "BRK-3581", "QDU-7649", "NLZ-1930", "WPL-8605", "DTV-4521", "SFX-7203", "CGH-9824", "ZQC-1876"};

        List<double> productPrice = new List<double>{1.23, 4.56, 7.89, 10.12, 13.45, 16.78, 19.01, 22.34, 25.67, 28.90, 31.23, 34.56, 37.89, 40.12, 43.45, 46.78, 49.01, 52.34, 55.67, 58.90};
        
        Random rnd = new Random();
        int productQuantity = rnd.Next(1, 100);
        int names_index = rnd.Next(productNames.Count);
        int id_index = rnd.Next(productID.Count);
        int price_index = rnd.Next(productPrice.Count);

        p1.SetQuantity(productQuantity);
        p1.SetName(productNames[names_index]);
        p1.SetID(productID[id_index]);
        p1.SetPrice(productPrice[price_index]);

    }
    static void CreateCustomer(Customer c1){
    List<string> customerName = new List<string>{
            "Liаm Stonebrook", "Sophia Winters", "Ethan Blackwood", "Isabella Sterling", "Maximus Drake", "Olivia Hawthorne", "Alexander Crest", "Maya Rivers", "Julian Foxwell", "Chloe Kensington", "Grayson O’Malley", "Ava Everhart", "Noah Wilder", "Charlotte Montgomery", "Theo Westbrook", "Emma Kingsley", "Landon Steele", "Madeline Blackwell", "Jameson Pierce", "Sienna Aldridge", "Hudson Vaughn", "Vivian Lancaster", "Logan Sinclair", "Penelope Graves", "Finnley West", "Hazel Donovan", "Quinn Bennett", "Daphne Lockwood", "Julian Sterling", "Ruby Ashton"
        };

        Random rnd = new Random();
        int name_index = rnd.Next(customerName.Count);
        c1.SetName(customerName[name_index]);
}

static void CreateAddress(Address a1){
    List<string> addressState = new List<string>{
        "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"
    };

    List<string> addressCity = new List<string>{
        "Starlight Falls", "Moonridge", "Silverbrook", "Crystal Haven", "Brightwater", "Windhill", "Falcon Bay", "Riverstone", "Eaglewood", "Goldenridge", "Mystic Hollow", "Sunset Cove", "Ashenbrook", "Everglade Heights", "Whispering Pines", "Stormvale", "Redwood Shores", "Diamond Peak", "Shadowbrook", "Violet Springs"
    };

    List<string> addressStreet = new List<string>{
        "Whispering Willow Lane", "Silver Oak Avenue", "Crimson Ridge Road", "Goldenbrook Drive", "Moonlight Crescent", "Starfield Way", "Timberwood Path", "Falconcrest Boulevard", "Bluebell Court", "Pinehurst Drive", "Emerald Grove Street", "Sunset Trail", "Ivory Pines Way", "Maple Hollow Lane", "Riverstone Parkway", "Cedarwood Circle", "Hawk's Nest Lane", "Shady Meadows Road", "Starlight Passage", "Coral Reef Street"
        };
    List<string> addressCountry = new List<string>{
        "Valoria", "Zaloria", "Astrevia", "Drakonia", "Lunaris", "Feldara", "Solandria", "Virelia", "Ravinthia", "Orliva", "Caldoria", "Thalasia", "Eryndor", "Zephyria", "Tarvona", "Meridora", "Nuvoria", "Sylvanna", "Eldoria", "Vesnara", "USA", "United States of America", "United States"
        };

        Random rnd = new Random();
        int index = rnd.Next(addressState.Count);
        a1.SetState(addressState[index]);

        index = rnd.Next(addressCity.Count);
        a1.SetCity(addressCity[index]);

        index = rnd.Next(addressStreet.Count);
        a1.SetStreet(addressStreet[index]);

        index = rnd.Next(addressCountry.Count);
        a1.SetState(addressCountry[index]);

}
}

