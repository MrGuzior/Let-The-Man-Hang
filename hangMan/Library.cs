using System;
namespace hangMan
{
    public static class Library
    {
        //Display category
        public static void GetCategory(int input)
        {
            Globals.category = list[input][0];
        }
    //Get random phrase from a random category

    //public static void GetPhrase()
    //{
    //    int category = RandomPhrase.getRandomPhrase("category", list.Length);
    //    int word = RandomPhrase.getRandomPhrase("word", category);
    //    Globals.phrase = Library.list[category][word];
    //    GetCategory(category);
    //}

    public static void GetPhrase()
    {
      //int category = RandomPhrase.getRandomPhrase("category", list.Length);
      //int word = RandomPhrase.getRandomPhrase("word", category);
      int word = 1;
      int category = 1;
      Globals.phrase = Library.list[category][word];
      GetCategory(category);
    }


    //Set category for random word
    public static void SetCategory(string input)
        {
            switch (input)
            {
                case "i":
                    PhraseInput.GetPhrase();
                    Globals.category = "General";
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    GetRandomPhrase(Int32.Parse(input));
                    break;
                default:
                    GetPhrase();
                    break;
            }
        }
        //Get random phrase from set category
        public static void GetRandomPhrase(int input)
        {
            int word = RandomPhrase.getRandomPhrase("word", input);
            Globals.phrase = Library.list[input][word];
            GetCategory(input);
        }
        //Phrase list, first word is used as Category name to display
        public static string[][] list =
        {
            /*Geography*/
            new string[] {
              "Geography", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan",
              "Bahamas","Bahrain","Bangladesh","Barbados","Belarus","Belgium","Belize","Bhutan","Bolivia","Bosnia and Herzegovina","Botswana","Brazil","Bulgaria","Burma",
              "Cambodia","Cameroon","Canada","Chad","Chile","China","Costa Rica","Croatia","Cuba","Cyprus","Czech Republic",
              "Denmark","Dominican Republic","Ecuador","Egypt","El Salvador","Estonia","Ethiopia",
              "Finland", "France",
              "Georgia", "Germany", "Greece",
              "Honduras","Hungary",
              "Iceland","India","Indonesia","Iran","Iraq","Ireland","Israel","Italy",
              "Jamaica","Japan",
              "Kazakhstan","Kenya","North Korea","South Korea",
              "Latvia", "Lebanon", "Liberia", "Liechtenstein","Lithuania","Luxembourg",
              "Macedonia", "Madagascar", "Malaysia", "Maldives", "Malta", "Mexico", "Moldava", "Monaco", "Mongolia", "Morocco",
              "Namibia", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway",
              "Oman",
              "Pakistan", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Poland", "Poland",
              "Quatar",
              "Romania", "Russia",
              "Saint Lucia", "San Marino", "Saudi Arabia", "Senegal", "Serbia", "Singapore",
              "Slovakia", "Slovenia", "Somalia", "Spain", "Sweden", "Syria", "Switzerland",
              "Thailand", "Tanzania", "Togo", "Tunisia", "Turkey",
              "Uganda", "Ukraine", "United Kindom", "United States of America", "Uruguay",
              "Venezuela", "Vietnam", "Vatican City",
              "Yemen",
              "Zambia", "Zimbabwe",
              "Africa", "Antarctic Circle", "Arctic", "Asia", "Australia", "Capital", "City", "Continent", "Country", "Earth",
              "Europe", "east", "west", "north", "south", "equator", "globe", "GPS", "hemisphere", "island", "kilometers",
              "meters", "land", "latitude", "longitude", "magnetic pole", "map", "miles", "mountain", "North America", "northwest",
              "ocean", "pole", "prime meridian", "region", "river", "sea", "sea level", "South America", "territory", "time zone",
              "topography", "tropics", "world",
              "Buenos Aires", "Minsk", "Brussels", "Sarajevo", "Brasilia", "Ottawa", "Beijing", "Zagreb", "Prague", "Copenhagen",
              "Tallinn", "Helsinki", "Paris", "Berlin", "Athens", "Budapest", "Reykjavik", "New Delhi", "Dublin", "Rome", "Tokyo",
              "Riga", "Amsterdam", "Oslo", "Lima", "Lisbon", "Moscow", "Bratislava", "Madrid", "Ankara", "London", "Warsaw", "Bucharest"
            },
            /*Weather*/
            new string[] {
              "Weather", "air", "air pressure", "atmosphere", "aurora", "autumn", "avalanche", "barometer", "biosphere", "blizzard",
              "breeze", "cirrus", "climate", "cloud", "cold front", "condensation", "contrail", "convergence", "cumulunimbus",
              "cumulus", "cyclone", "current", "degree", "dew", "drought", "dust devil", "evaporation", "flood", "fog",
              "forecast", "frost", "global warming", "hail", "heat wave", "humidity", "hurricane season", "ice age",
              "inversion", "jet stream", "lightning", "meteorology", "ozone layer", "precipitation", "pressure",
              "rain", "rainbow", "sky", "smog", "slush", "snowflake", "snowstorm", "spring", "storm", "stratosphere",
              "summer", "sunrise", "sunset", "temperature", "thunder", "thunderstorm", "tornado", "tropical", "turbulence",
              "twilight", "twister", "typhoon", "upwind", "vapor", "water cycle", "wave", "weather", "weather baloon",
              "wind", "winter", "zone"
            },
            /*Animals*/
            new string[] {
              "Animals", "African elephant", "Albatross", "alligator", "alpaca", "bison", "anaconda", "angelfish", "amphibian", "animal",
              "ant", "arctic fox", "armadillo", "arthropod", "baboon", "bactrian camel", "badger", "bald eagle", "basilisk",
              "bass", "bat", "bear", "beaver", "bee", "beetle", "beluga whale", "bird", "blowfish", "blue whale", "buffalo",
              "bug", "bulldog", "butterfly", "camel", "canada goose", "capybera", "cat", "cat", "cat", "caterpillar",
              "cattle", "chameleon", "cheetah", "chicken", "chihuahua", "chimpanzee", "chinchilla", "chinchilla", "clam",
              "clownfish", "cobra", "cockroach", "cod", "collie", "coral", "cougar", "cow", "cow", "cow", "coyote", "crab",
              "crayfish", "cricket", "crocodile", "deer", "dingo", "dinosaur", "dodo", "dog", "dog", "dog", "dolphin", "dove",
              "donkey", "dragonfly", "dromedary", "duck", "eagle", "eel", "eel", "eel", "elephant", "elk", "emu", "falcon",
              "fennec fox", "ferret", "finch", "firefly", "fish", "flamingo", "flea", "flea", "fly", "fly", "fox", "fox", "fox",
              "frog", "fruit bat", "gecko", "german shepherd", "gibbon", "giraffe", "gnu", "goat", "gnu", "goat", "goldfish",
              "goose", "gorilla", "grasshopper", "grizzly bear", "guinea pig", "gull", "hammerhead shark", "hamster", "hawk",
              "hawk", "hen", "hedgehog", "hermit crab", "hippo", "hippopotamus", "honey bee", "hornet", "horse", "human being",
              "homo sapiens", "hummingbird", "husky", "hyena", "iguana", "insect", "jaguar", "jellyfish", "kangaroo", "king cobra",
              "kiwi", "kiwi", "koala", "koala", "krill", "ladybug", "larva", "lemming", "lemur", "leopard", "lice", "lion", "lion",
              "lizard", "llama", "lobster", "lynx", "lynx", "mamba", "mammal", "mammoth", "manatee", "manta ray", "marmot",
              "marsupial", "mice", "mink", "mole", "mongoose", "monkey", "moose", "mosquito", "moth", "mouse", "narwhal", "ocelot",
              "nightingale", "orca", "ostrich", "otter", "owl", "owl", "owl", "ox", "ox", "ox", "ox", "oyster", "panda", "panda",
              "panther", "parrot", "peacock", "pelican", "pelican", "penguin", "pig", "pig", "pig", "pigeon", "plankton", "pika",
              "piranha", "placental mammals", "platypus", "polar bear", "poodle", "praying mantis", "primates", "pufferfish",
              "puma", "puma", "python", "python", "python", "rabbit", "raccoon", "rat", "rat", "rat", "rattlesnake", "ray",
              "red panda", "reindeer", "reptile", "rhino", "rhino", "roach", "robin", "rodent", "rooster", "salamander", "salmon",
              "scorpion", "sea cucumber", "sea turtle", "seahorse", "seal", "seal", "shark", "sheep", "shrew", "shrimp", "silkworm",
              "silverfish", "skunk", "sloth", "slug", "snail", "snake", "snake", "sparrow", "spider", "sponge", "squid", "squirrel",
              "starfish", "starling", "stingray", "stork", "sugar glider", "swift", "swordfish", "tadpole", "tarantula", "termite",
              "tasmanian devil", "tick", "tiger", "tiger", "tiger", "toad", "tortoise", "toucan", "tsetse fly", "tuna", "tuna",
              "turkey", "turtle", "tyrannosaurus rex", "vampire bat", "vertebrates", "viper", "walrus", "wasp", "whale", "whale",
              "white dove", "wolf", "wolf", "wolf", "wolverine", "wombat", "woodpecker", "woodchuck", "woolly mammoth", "worm",
              "yak", "yak", "zebra"
            },
            /*Plants*/
            new string[] {
              "Plants", "acorn", "bamboo", "bark", "bean", "berry", "blossom", "botany", "bud", "bush", "cactus", "canopy", "clover", "cork",
              "fern", "fertilizer", "flora", "flower", "forest", "fruit", "garden", "ginkgo", "grain", "grass", "grow", "gum",
              "herb", "hybrid", "ivy", "ivy", "jungle", "kelp", "juniper", "leaf", "leaf", "leaf", "lily", "moss", "nectar", "nut",
              "palm", "palm", "petal", "photosynthesis", "pollen", "pollinate", "resin", "root", "root", "sap", "sapling", "sea weed",
              "seed", "soil", "spore", "sprout", "stem", "thorn", "tree", "tree", "tree", "trunk", "trunk", "twig", "vine", "vegetable",
              "weed", "weed", "weed", "weed", "wood", "wood", "wood"
            },
            /*Food*/
            new string[] {
              "Food", "almond", "anchovy", "appetite", "appetizer", "apple", "apricot", "artichoke", "asparagus", "avocado", "bacon", "bagel",
              "banana", "banana", "basil", "beans", "beef", "beef", "beet", "beet", "bell pepper", "berry", "biscuit", "bitter",
              "black tea", "blackberry", "blueberry", "boil", "bowl", "bread", "broccoli", "broil", "brownie", "brunch", "buns",
              "burrito", "butter", "cake", "calorie", "candy", "caramel", "carrot", "cashew", "cauliflower", "caviar", "cayenne pepper",
              "celery", "cereal", "cheddar", "cheese", "cheesecake", "chef", "cherry", "chew", "chicken", "chili", "chips", "chocolate",
              "chopsticks", "cinnamon", "citron", "citrus", "clam", "coconut", "cod", "coffee", "coleslaw", "cook", "corn", "cornflakes",
              "crab", "crackers", "cranberry", "cream", "cream cheese", "crisp", "crust", "curry", "dairy", "dates", "dessert", "diet",
              "digest", "dill", "dill", "diner", "dine", "dish", "dough", "dressing", "drink", "dry", "eat", "egg", "egg", "eggplant",
              "fat", "fast food", "fat", "fig", "fig", "fillet", "fish", "flour", "food", "fork", "freezer", "fried", "fruit", "fry",
              "garlic", "gastronomy", "gelatin", "ginger", "ginger ale", "grain", "grape", "grapefruit", "gravy", "guacamole", "ham",
              "ham", "hamburger", "hash", "hazelnut", "herbs", "honey", "hot dog", "hunger", "ice", "ice cream", "jalapeno", "jam", "jam",
              "jelly", "jug", "juice", "junk food", "kebab", "ketchup", "kettle", "kitchen", "kiwi", "lamb", "lasagna", "lemon", "lemonade",
              "lettuce", "licorice", "lime", "lime", "liver", "loaf", "lollipop", "lunch", "macaroni", "mango", "maple syrup", "margarine",
              "marmalade", "marshmallow", "mayonnaise", "meat", "meat", "meatball", "melon", "menu", "milk", "mint", "muffin", "mug",
              "mustard", "mutton", "napkin", "nectar", "noodles", "nourishment", "nut", "nut", "oatmeal", "oats", "oil", "oil", "olive",
              "omlet", "onion", "orange", "oyster", "pancake", "papaya", "parsley", "parsnip", "pasta", "pea", "peach", "peanut", "pear",
              "peper", "pepperoni", "pickle", "pie", "pie", "pineapple", "pizza", "pizza", "pizza", "pizza", "plum", "pomegranate",
              "popcorn", "popcorn", "pork", "pork", "potato", "potato", "protein", "pudding", "pumpkin", "radish", "raisin", "raspberry",
              "ravioli", "recipe", "restaurant", "rhubarb", "ribs", "ribs", "rice", "rice", "rice", "rosemary", "salad", "salad", "salami",
              "salmon", "salsa", "salt", "sandwich", "sandwich", "saisage", "shrimp", "soda", "soda", "soup", "soup", "soy", "spaghetti",
              "spaghetti", "spinach", "stew", "strawberry", "sushi", "sushi", "sushi", "taco", "taco", "taco", "tea", "tea", "tea", "tea",
              "tofu", "tofu", "tomato", "tomato", "tortilla", "tortilla", "tuna", "tuna", "vanilla", "vegetable", "vinegar", "vitamin",
              "waffle", "wasabi", "water", "water", "wheat", "wok", "wok", "yohurt", "yolk", "zucchini"
            },
            /*Measurement*/
            new string[] {
              "Measurement", "acre", "area", "barrel", "bit", "bulk", "byte", "carat", "centimeter", "cubic", "cubuic meter", "cubit", "cup",
              "decigram", "decimal", "degree", "depth", "digit", "dozen", "drop", "feet", "foot", "gallon", "gauge", "grain",
              "gram", "hand", "hectare", "height", "inch", "karat", "kilo", "kilogram", "kilometer", "knot", "length", "light year",
              "liter", "mass", "measure", "megapixel", "meter", "metric system", "microgram", "micron", "mile", "milligram", "milliliter",
              "minute", "mole", "nanometer", "nautical mile", "octave", "order of magnitude", "ounce", "palm", "percent", "percentile",
              "pinch", "pint", "pixel", "pound", "quantity", "quarter", "radian", "ruler", "scale", "score", "spoon", "square kilometer",
              "tablespoon", "ton", "unit", "volume", "weight", "width", "yard"
            },
            /*Music*/
            new string[] {
              "Music", "accordion", "acoustic guitar", "bagpipe", "balalaika", "banjo", "banjo", "bass", "bell", "brass instruments",
              "cello", "cowbell", "drum", "drumsticks", "electric guitar", "flute", "guitar", "gong", "harmonica", "harp", "horn",
              "instrument", "keyboard", "lute", "organ", "piano", "piccolo", "pipe organ", "saxophone", "triangle", "tuba",
              "ukelele", "violin", "xylophone", "blues", "chord", "forte", "jazz", "jazz", "jazz", "jazz", "jazz", "jazz",
              "key", "major", "melody", "music", "notes", "octave", "opera", "piano", "pitch", "rhythm", "sonata", "tempo",
              "rock", "metal", "arctic monkeys", "the beatles", "blondie", "bob dylan", "bob marley", "carlos santana",
              "coldplay", "david bowie", "ed sheeran", "elton john", "elvis presley", "foo fighters", "frank sinatra", "green day",
              "guns n roses", "iggy pop", "jimi hendrix", "johnny cash", "kiss", "led zeppelin", "madonna", "michael jackson",
              "nirvana", "nina simone", "ozzy osbourne", "pink floyd", "the police", "prince", "queen", "red hot chili peppers",
              "the rolling stones", "sex pistols", "the who", "eminem"
            },
            /*Sports*/
            new string[] {
              "Sports", "archery", "athlete", "badminton", "ball", "baseball", "basketball", "bat", "bicycle", "bike", "bike", "billiards",
              "bowling", "boxer", "boxing", "canoe", "catch", "champion", "championship", "cricket", "curling", "cycling", "cyclist",
              "dart", "dartboard", "deadlifting", "diving", "exercise", "figure skating", "football", "football", "frisbee", "game",
              "goal", "gold medal", "golf", "gym", "gym", "gymnastics", "handball", "high jump", "hockey", "home run", "hoop",
              "ice skating", "jogger", "jump", "karate", "kayak", "kickball", "kite", "kung fu", "long jump", "medal", "net", "offense",
              "olympics", "paddling", "parkour", "ping pong", "ping pong", "ping pong", "play", "player", "pole vault", "polo", "race",
              "referee", "riding", "rowing", "rugby", "running", "sailing", "gliding", "score", "scuba", "skate", "bmx", "skiing",
              "sledding", "snorkeling", "snowboarding", "soccer", "softball", "sport", "squash", "surfing", "swimming", "target",
              "team", "tennis", "tie", "trampoline", "triple jump", "unicycle", "volley ball", "wakeboarding", "water ski",
              "weightlifting", "windsurfing"
            },
            /*Body*/
            new string[] {
              "Body", "abdomen", "anatomy", "ankle", "anus", "anus", "arm", "back", "belly", "big toe", "bladder", "blood", "blood vessels",
              "bone", "bone", "brain", "breast", "cell", "chest", "cheek", "chin", "collar bone", "ear", "elbow", "eye", "eye",
              "eyebrow", "eyelid", "face", "feet", "finger", "fingernail", "foot", "groin", "gums", "hair", "hand", "head", "heart",
              "heel", "hip", "hip", "jaw", "jaw", "knee", "leg", "leg", "lip", "lip", "liver", "lungs", "lungs", "muscle", "nail",
              "nerves", "nipple", "nose", "nostril", "pelvis", "pupil", "rectum", "ribs", "shin", "shoulder", "skin", "skull",
              "sole", "spine", "spleen", "stomach", "teeth", "thigh", "throat", "thumb", "toe", "tongue", "torso", "uvula", "vein",
              "waist", "wrist"
            },
            /*Science*/
            new string[] {
              "Science", "astronomy", "atom", "biology", "botany", "cell", "chemical", "chemistry", "climate", "data", "electricity", "element",
              "energy", "evolution", "experiment", "fossil", "genetics", "geology", "gravity", "hypothesis", "lab", "lab", "laboratory",
              "laws", "magnetism", "mass", "matter", "measure", "microscope", "mineral", "molecule", "motion", "organism", "paleontology",
              "particle", "physics", "research", "scale", "science", "scientist", "telescope", "theory", "thermometer", "tissue", "variable",
              "volume", "zoology", "Aluminium", "Argon", "Boron", "Calcium", "Carbon", "Chlorine", "Copper", "Fluorine", "Gold", "Helium",
              "Hydrogen", "Iron", "Lead", "Lithium", "Magnesium", "Manganese", "Mercury", "Neon", "Neon", "Nickel", "Nitrogen", "Oxygen",
              "Platinum", "Plutonium", "Radium", "Silicon", "Silver", "Sodium", "Sulfur", "Tin", "Tin", "Xenon", "Zinc", "Amber", "Coal",
              "crystal", "dolomite", "emerald", "fossil", "gem", "geode", "lava", "water", "magma", "moonstone", "opal", "quartz", "rock",
              "ruby", "salt", "topaz", ""
            },
            /*Computer*/
            new string[] {
              "Computer" ,"algorithm", "analog", "app", "app", "app", "application", "array", "backup", "binary", "bit", "bite", "bitmap", "blog",
              "bookmark", "boot", "browser", "buffer", "bug", "bus", "byte", "cache", "caps lock", "captcha", "cd", "cd", "client",
              "clip board", "command", "compile", "compress", "computer", "configure", "cookie", "copy", "cpu", "dashboard", "data",
              "database", "debug", "decompress", "delete", "desktop", "development", "digital", "disk", "document", "domain",
              "download", "DVD", "email", "emoticon", "encrypt", "enter", "file", "firewall", "flash drive", "flowchart", "folder",
              "font", "format", "gigabyte", "graphics", "hack", "hardware", "home page", "host", "html", "hypertext", "icon",
              "integer", "interface", "internet", "IP adress", "Java", "Java Script", "joystick", "keyboard", "laptop", "link",
              "Linux", "log out", "logic", "login", "Macintosh", "malware", "media", "memory", "monitor", "motherboard", "mouse",
              "network", "net", "net", "net", "offline", "online", "node", "option", "output", "page", "page", "password", "paste",
              "path", "platform", "podcast", "portal", "print", "printer", "privacy", "process", "function", "program", "programmer",
              "protocol", "QWERTY", "RAM", "reboot", "ROM", "root", "RAM", "ROM", "root", "router", "runtime", "save", "scan", "screen",
              "screenshot", "script", "scroll", "search engine", "seciurity", "server", "shift", "spam", "software", "spyware", "storage",
              "surf", "syntax", "table", "tag", "teminal", "CSS", "CSS", "terminal", "template", "terabyte", "text editor", "toolbar",
              "undo", "Unix", "upload", "URL", "URL", "user", "username", "utility", "version", "virtual", "virus", "web", "website",
              "widget", "wiki", "window", "Windows", "wireless", "World Wide Web", "WWW", "WWW", "XML", "ZIP", "C", "Python", "React"
            }
        };
        
    }
}
