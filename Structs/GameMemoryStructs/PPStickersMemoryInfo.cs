using System.Runtime.InteropServices;

namespace SRTPluginProviderDR1.Structs.GameStructs
{
    /// <summary>
    /// Structure for weapon information
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 0x194)]
    public struct PPStickersMemoryInfo
    {
        #region Fields

        /// <summary>
        /// Field for the green vase in Paradise Plaza
        /// </summary>
        [FieldOffset(0x0)] internal int _greenVasePP;
        
        /// <summary>
        /// Field for the Jade's Paradise in Food Court
        /// </summary>
        [FieldOffset(0x4)] internal int _jadeParadiseFC;

        /// <summary>
        /// Field for the ratman in Movie Land
        /// </summary>
        [FieldOffset(0x8)] internal int _insideRatmanML;

        /// <summary>
        /// Field for the Movie Land in Paradise Plaza
        /// </summary>
        [FieldOffset(0xC)] internal int _movieLandSignPP;

        /// <summary>
        /// Field for the Drug bottle in Seon's Food
        /// </summary>
        [FieldOffset(0x10)] internal int _pharmacyDrugBottleSF;

        /// <summary>
        /// Field for the cupid fountain in North Plaza
        /// </summary>
        [FieldOffset(0x14)] internal int _cupidFountainNP;

        /// <summary>
        /// Field for the green balloon in Wonder Plaza
        /// </summary>
        [FieldOffset(0x18)] internal int _greenBalloonWP;

        /// <summary>
        /// Field for the pink bunny in Wonder Plaza
        /// </summary>
        [FieldOffset(0x1C)] internal int _pinkBunnyWP;

        /// <summary>
        /// Field for the Sir Book-A-Lot in Wonder Plaza
        /// </summary>
        [FieldOffset(0x20)] internal int _sirBookALotWP;

        /// <summary>
        /// Field for the Colombus Roastmaster in Al Fresca
        /// </summary>
        [FieldOffset(0x24)] internal int _colombusRoastmasterSignAF;

        /// <summary>
        /// Field for the Burger Menu in Al Fresca
        /// </summary>
        [FieldOffset(0x28)] internal int _burgerMenuAL;

        /// <summary>
        /// Field for the Food Court in Al Fresca
        /// </summary>
        [FieldOffset(0x2C)] internal int _foodCourtSignAL;

        /// <summary>
        /// Field for the Big Chriss Head in Food Court
        /// </summary>
        [FieldOffset(0x30)] internal int _bigChrissHeadFC;

        /// <summary>
        /// Field for the Big Food Court Sign in Food Court
        /// </summary>
        [FieldOffset(0x34)] internal int _foodCourtSignFC;

        /// <summary>
        /// Field for the Bull Head in Food Court
        /// </summary>
        [FieldOffset(0x38)] internal int _bullHeadFC;

        /// <summary>
        /// Field for the Seagull Clock in Paradise Plaza
        /// </summary>
        [FieldOffset(0x3C)] internal int _seagullClockPP;

        /// <summary>
        /// Field for the Teddy Bears in Paradise Plaza
        /// </summary>
        [FieldOffset(0x40)] internal int _teddyBearsPP;

        /// <summary>
        /// Field for the Clock in Paradise Plaza
        /// </summary>
        [FieldOffset(0x44)] internal int _clockPP;

        /// <summary>
        /// Field for the small chriss in Food Court
        /// </summary>
        [FieldOffset(0x48)] internal int _smallChrisHeadFC;

        /// <summary>
        /// Field for the Meaty Burger in Food Court
        /// </summary>
        [FieldOffset(0x4C)] internal int _meatyBurgersFC;

        /// <summary>
        /// Field for the Frozen Dreams in Food Court
        /// </summary>
        [FieldOffset(0x50)] internal int _frozenDreamsFC;

        /// <summary>
        /// Field for the Cowboy in Food Court
        /// </summary>
        [FieldOffset(0x54)] internal int _cowboyFC;

        /// <summary>
        /// Field for the Windmill in Wonder Plaza
        /// </summary>
        [FieldOffset(0x58)] internal int _windmillWP;

        /// <summary>
        /// Field for the Seon Food Sign in North Plaza
        /// </summary>
        [FieldOffset(0x5C)] internal int _seonFoodSignNP;

        /// <summary>
        /// Field for the Crislip Sign in North Plaza
        /// </summary>
        [FieldOffset(0x60)] internal int _crislipSignNP;

        /// <summary>
        /// Field for the Columbian Roastmaster in Paradise Plaza
        /// </summary>
        [FieldOffset(0x64)] internal int _columbianRoastmasterPP;

        /// <summary>
        /// Field for the Basket Ball Hoops in Paradise Plaza
        /// </summary>
        [FieldOffset(0x68)] internal int _basketballHoopsPP;

        /// <summary>
        /// Field for the Antic Sword in North Plaza
        /// </summary>
        [FieldOffset(0x6C)] internal int _anticSwordsNP;

        /// <summary>
        /// Field for the Antic Sword 2 in North Plaza
        /// </summary>
        [FieldOffset(0x70)] internal int _anticSwords2NP;

        /// <summary>
        /// Field for the Dear Head in North Plaza
        /// </summary>
        [FieldOffset(0x74)] internal int _dearHeadNP;

        /// <summary>
        /// Field for the Dead Head 2 in North Plaza
        /// </summary>
        [FieldOffset(0x78)] internal int _dearHead2NP;

        /// <summary>
        /// Field for the Refined Class Shoes in Entrance Plaza
        /// </summary>
        [FieldOffset(0x7C)] internal int _refinedClassShoesEP;

        /// <summary>
        /// Field for the Small Fry Dudes in Wonder Plaza
        /// </summary>
        [FieldOffset(0x80)] internal int _smallFryDudesPhotoWP;

        /// <summary>
        /// Field for the North Clocktower in Leisure Park
        /// </summary>
        [FieldOffset(0x84)] internal int _northClocktowerLP;

        /// <summary>
        /// Field for the Megaman Shirt in Paradise Plaza
        /// </summary>
        [FieldOffset(0x88)] internal int _megamanShirtPP;

        /// <summary>
        /// Field for the Tune maker in Paradise Plaza
        /// </summary>
        [FieldOffset(0x8C)] internal int _tuneMakerPP;

        /// <summary>
        /// Field for the Jill Sandwich in Paradise Plaza
        /// </summary>
        [FieldOffset(0x90)] internal int _jillSandwichPP;

        /// <summary>
        /// Field for the Tyke N Tots in Paradise Plaza
        /// </summary>
        [FieldOffset(0x94)] internal int _tykeNTotsPP;

        /// <summary>
        /// Field for the Bee Head in Entrance Plaza
        /// </summary>
        [FieldOffset(0x98)] internal int _beeHeadEP;

        /// <summary>
        /// Field for the Wendy in Paradise Plaza
        /// </summary>
        [FieldOffset(0x9C)] internal int _wendyPP;

        /// <summary>
        /// Field for the Servbot in Paradise Plaza
        /// </summary>
        [FieldOffset(0xA0)] internal int _serbotPP;

        /// <summary>
        /// Field for the Teddy Bears in Entrance Plaza
        /// </summary>
        [FieldOffset(0xA4)] internal int _teddyBearsEP;

        /// <summary>
        /// Field for the Green Vase in Entrance Plaza
        /// </summary>
        [FieldOffset(0xA8)] internal int _greenVaseEP;

        /// <summary>
        /// Field for the Crown in Entrance Plaza
        /// </summary>
        [FieldOffset(0xAC)] internal int _crownEP;

        /// <summary>
        /// Field for the Coque Poster in Entrance Plaza
        /// </summary>
        [FieldOffset(0xB0)] internal int _coquePosterEP;

        /// <summary>
        /// Field for the PP sticker shirt in Wonder Plaza
        /// </summary>
        [FieldOffset(0xB4)] internal int _ppStickerShirtWP;

        /// <summary>
        /// Field for the Air Duct in Safe House
        /// </summary>
        [FieldOffset(0xB8)] internal int _airDuctSH;

        /// <summary>
        /// Field for the Pink Bunny in Wonder Plaza
        /// </summary>
        [FieldOffset(0xBC)] internal int _pinkBunny2WP;

        /// <summary>
        /// Field for the Yellow House 2 in Wonder Plaza
        /// </summary>
        [FieldOffset(0xC0)] internal int _yellowHouse2WP;

        /// <summary>
        /// Field for the Yellow House in Wonder Plaza
        /// </summary>
        [FieldOffset(0xC4)] internal int _yellowHouseWP;

        /// <summary>
        /// Field for the Baseball team photo in Wonder Plaza
        /// </summary>
        [FieldOffset(0xC8)] internal int _baseballTeamPhotoWP;

        /// <summary>
        /// Field for the American Flag in North Plaza
        /// </summary>
        [FieldOffset(0xCC)] internal int _americanFlagNP;

        /// <summary>
        /// Field for the American Hunter in North Plaza
        /// </summary>
        [FieldOffset(0xD0)] internal int _americanHunterNP;

        /// <summary>
        /// Field for the Meat Seon in Seon
        /// </summary>
        [FieldOffset(0xD4)] internal int _meatSeon;

        /// <summary>
        /// Field for the Seafood Seon in Seon
        /// </summary>
        [FieldOffset(0xD8)] internal int _seafoodSeon;

        /// <summary>
        /// Field for the Stairwell Advertisement in Paradise Plaza
        /// </summary>
        [FieldOffset(0xDC)] internal int _stairwellAdvertisementPP;

        /// <summary>
        /// Field for the Kids Cloth Choice in Paradise Plaza
        /// </summary>
        [FieldOffset(0xE0)] internal int _kidsClothChoicePP;

        /// <summary>
        /// Field for the Kokonuts Sign in Wonder Plaza
        /// </summary>
        [FieldOffset(0xE4)] internal int _kokonutsSignWP;

        /// <summary>
        /// Field for the Astronauts 2 in Wonder Plaza
        /// </summary>
        [FieldOffset(0xE8)] internal int _astronauts2WP;

        /// <summary>
        /// Field for the Space Rider Sign in Wonder Plaza
        /// </summary>
        [FieldOffset(0xEC)] internal int _spaceRiderSignWP;

        /// <summary>
        /// Field for the Astronaut in Wonder Plaza
        /// </summary>
        [FieldOffset(0xF0)] internal int _astronautsWP;

        /// <summary>
        /// Field for the Alien Sign in Wonder Plaza
        /// </summary>
        [FieldOffset(0xF4)] internal int _alienSignWP;

        /// <summary>
        /// Field for the Wendy in Entrance Plaza
        /// </summary>
        [FieldOffset(0xF8)] internal int _wendy2EP;

        /// <summary>
        /// Field for the Tick the Fox in Entrance Plaza
        /// </summary>
        [FieldOffset(0xFC)] internal int _tickTheFox3EP;

        /// <summary>
        /// Field for the Lifestyle Sign in Stuff market 
        /// </summary>
        [FieldOffset(0x100)] internal int _lifestyleStuff;

        /// <summary>
        /// Field for the Gardening Sign in Stuff market 
        /// </summary>
        [FieldOffset(0x104)] internal int _gardeningSignStuff;

        /// <summary>
        /// Field for the Megaman Fist in Paradise Plaza
        /// </summary>
        [FieldOffset(0x108)] internal int _megamanFistPP;

        /// <summary>
        /// Field for the ratman movie in Paradise Plaza
        /// </summary>
        [FieldOffset(0x10C)] internal int _ratmanMoviePP;

        /// <summary>
        /// Field for Ticky The Fox 2 in Movie Land
        /// </summary>
        [FieldOffset(0x110)] internal int _tickyTheFox2ML;

        /// <summary>
        /// Field for Ticky The Fox in Movie Land
        /// </summary>
        [FieldOffset(0x114)] internal int _tickyTheFoxML;

        /// <summary>
        /// Field for Dorry Poster in Movie Land
        /// </summary>
        [FieldOffset(0x118)] internal int _dorryPosterML;

        /// <summary>
        /// Field for Megaman Poster in Movie Land
        /// </summary>
        [FieldOffset(0x11C)] internal int _megamanPosterML;

        /// <summary>
        /// Field for Ratman Poster in Movie Land
        /// </summary>
        [FieldOffset(0x120)] internal int _ratmanPosterML;

        /// <summary>
        /// Field for Pride Poster in Movie Land
        /// </summary>
        [FieldOffset(0x124)] internal int _pridePosterML;

        /// <summary>
        /// Field for Bomb 3 Truck in Tunnel
        /// </summary>
        [FieldOffset(0x128)] internal int _bomb3TruckT1;

        /// <summary>
        /// Field for Bomb 2 Truck in Tunnel
        /// </summary>
        [FieldOffset(0x12C)] internal int _bomb2TruckT1;

        /// <summary>
        /// Field for Bomb 4 Truck in Tunnel
        /// </summary>
        [FieldOffset(0x130)] internal int _bomb4TruckT1;

        /// <summary>
        /// Field for Bomb 5 Truck in Tunnel
        /// </summary>
        [FieldOffset(0x134)] internal int _bomb5TruckT1;

        /// <summary>
        /// Field for Bomb 1 Truck in Tunnel
        /// </summary>
        [FieldOffset(0x138)] internal int _bomb1TruckT1;

        /// <summary>
        /// Field for Beaf Schema in Tunnel
        /// </summary>
        [FieldOffset(0x13C)] internal int _beafschemaT2;

        /// <summary>
        /// Field for Beaf Extractor in Tunnel
        /// </summary>
        [FieldOffset(0x140)] internal int _beafExtractorT2;

        /// <summary>
        /// Field for the East Clocktower in Leisure Park
        /// </summary>
        [FieldOffset(0x144)] internal int _eastClocktowerLP;

        /// <summary>
        /// Field for the South Clocktower in Leisure Park
        /// </summary>
        [FieldOffset(0x148)] internal int _southClocktowerLP;

        /// <summary>
        /// Field for the Clearance Sign in Al fresca
        /// </summary>
        [FieldOffset(0x14C)] internal int _clearanceSignLP;

        /// <summary>
        /// Field for the Bike in Al fresca
        /// </summary>
        [FieldOffset(0x150)] internal int _bikeAL;

        /// <summary>
        /// Field for the Four Posters in Al fresca
        /// </summary>
        [FieldOffset(0x154)] internal int _fourPostersAL;

        /// <summary>
        /// Field for the Weight Machine in Al fresca
        /// </summary>
        [FieldOffset(0x158)] internal int _weightMachineAL;

        /// <summary>
        /// Field for the Body Builder in Al fresca
        /// </summary>
        [FieldOffset(0x15C)] internal int _bodyBuildersAL;

        /// <summary>
        /// Field for the Flexin Sign in Al fresca
        /// </summary>
        [FieldOffset(0x160)] internal int _flexinSignAL;

        /// <summary>
        /// Field for the Running Machine in Al fresca
        /// </summary>
        [FieldOffset(0x164)] internal int _runningMachineAL;

        /// <summary>
        /// Field for the Brand New Shoes in Al fresca
        /// </summary>
        [FieldOffset(0x168)] internal int _brandNewShoesAL;

        /// <summary>
        /// Field for the Optical Guy Poster in Al fresca
        /// </summary>
        [FieldOffset(0x16C)] internal int _opticalGuyPosterAL;

        /// <summary>
        /// Field for the Central Taco in Food Court
        /// </summary>
        [FieldOffset(0x170)] internal int _centralTacoFC;

        /// <summary>
        /// Field for the Dark Bean in Food Court
        /// </summary>
        [FieldOffset(0x174)] internal int _darkBeanFC;

        /// <summary>
        /// Field for the Teresa Oven Pizza in Food Court
        /// </summary>
        [FieldOffset(0x178)] internal int _teresaOvenFC;

        /// <summary>
        /// Field for the Entrance Door in Entrance Plaza
        /// </summary>
        [FieldOffset(0x17C)] internal int _entranceDoorEP;

        /// <summary>
        /// Field for the Ticky the Fox in Cultist
        /// </summary>
        [FieldOffset(0x180)] internal int _tickyTheFoxCultist;

        /// <summary>
        /// Field for the Camping Tent in Entrance Plaza
        /// </summary>
        [FieldOffset(0x184)] internal int _campingTentEP;

        /// <summary>
        /// Field for the Bulletin Board in Safe House
        /// </summary>
        [FieldOffset(0x188)] internal int _bulletinBoardSH;

        /// <summary>
        /// Field for the Cultist Sign in Cultist
        /// </summary>
        [FieldOffset(0x190)] internal int _cultistSignCultist;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the green vase in Paradise Plaza
        /// </summary>
        public int GreenVasePP => _greenVasePP;

        /// <summary>
        /// Gets or sets the Jade's Paradise in Food Court
        /// </summary>
        public int JadeParadiseFC => _jadeParadiseFC;

        /// <summary>
        /// Gets or sets for the ratman in Movie Land
        /// </summary>
        public int InsideRatmanML => _insideRatmanML;

        /// <summary>
        /// Gets or sets the Movie Land in Paradise Plaza
        /// </summary>
        public int MovieLandSignPP => _movieLandSignPP;

        /// <summary>
        /// Gets or sets the Drug bottle in Seon's Food
        /// </summary>
        public int PharmacyDrugBottleSF => _pharmacyDrugBottleSF;
        public int CupidFountainNP => _cupidFountainNP;
        public int GreenBalloonWP => _greenBalloonWP;
        public int PinkBunnyWP => _pinkBunnyWP;
        public int SirBookALotWP => _sirBookALotWP;
        public int ColombusRoastmasterSignAF => _colombusRoastmasterSignAF;
        public int BurgerMenuAL => _burgerMenuAL;
        public int FoodCourtSignAL => _foodCourtSignAL;
        public int BigChrissHeadFC => _bigChrissHeadFC;
        public int FoodCourtSignFC => _foodCourtSignFC;
        public int BullHeadFC => _bullHeadFC;
        public int SeagullClockPP => _seagullClockPP;
        public int TeddyBearsPP => _teddyBearsPP;
        public int ClockPP => _clockPP;
        public int SmallChrisHeadFC => _smallChrisHeadFC;
        public int MeatyBurgersFC => _meatyBurgersFC;
        public int FrozenDreamsFC => _frozenDreamsFC;
        public int CowboyFC => _cowboyFC;
        public int WindmillWP => _windmillWP;
        public int SeonFoodSignNP => _seonFoodSignNP;
        public int CrislipSignNP => _crislipSignNP;
        public int ColumbianRoastmasterPP => _columbianRoastmasterPP;
        public int BasketballHoopsPP => _basketballHoopsPP;
        public int AnticSwordsNP => _anticSwordsNP;
        public int AnticSwords2NP => _anticSwords2NP;
        public int DearHeadNP => _dearHeadNP;
        public int DearHead2NP => _dearHead2NP;
        public int RefinedClassShoesEP => _refinedClassShoesEP;
        public int SmallFryDudesPhotoWP => _smallFryDudesPhotoWP;
        public int NorthClocktowerLP => _northClocktowerLP;
        public int MegamanShirtPP => _megamanShirtPP;
        public int TuneMakerPP => _tuneMakerPP;
        public int JillSandwichPP => _jillSandwichPP;
        public int TykeNTotsPP => _tykeNTotsPP;
        public int BeeHeadEP => _beeHeadEP;
        public int WendyPP => _wendyPP;
        public int SerbotPP => _serbotPP;
        public int TeddyBearsEP => _teddyBearsEP;
        public int GreenVaseEP => _greenVaseEP;
        public int CrownEP => _crownEP;
        public int CoquePosterEP => _coquePosterEP;
        public int PpStickerShirtWP => _ppStickerShirtWP;
        public int AirDuctSH => _airDuctSH;
        public int PinkBunny2WP => _pinkBunny2WP;
        public int YellowHouse2WP => _yellowHouse2WP;
        public int YellowHouseWP => _yellowHouseWP;
        public int BaseballTeamPhotoWP => _baseballTeamPhotoWP;
        public int AmericanFlagNP => _americanFlagNP;
        public int AmericanHunterNP => _americanHunterNP;
        public int MeatSeon => _meatSeon;
        public int SeafoodSeon => _seafoodSeon;
        public int StairwellAdvertisementPP => _stairwellAdvertisementPP;
        public int KidsClothChoicePP => _kidsClothChoicePP;
        public int KokonutsSignPP => _kokonutsSignWP;
        public int Astronauts2WP => _astronauts2WP;
        public int SpaceRiderSignWP => _spaceRiderSignWP;
        public int AstronautsWP => _astronautsWP;
        public int AlienSignWP => _alienSignWP;
        public int Wendy2EP => _wendy2EP;
        public int TickTheFox3EP => _tickTheFox3EP;
        public int LifestyleStuff => _lifestyleStuff;
        public int GardeningSignStuff => _gardeningSignStuff;
        public int MegamanFistPP => _megamanFistPP;
        public int RatmanMoviePP => _ratmanMoviePP;
        public int TickyTheFox2ML => _tickyTheFox2ML;
        public int TickyTheFoxML => _tickyTheFoxML;
        public int DorryPosterML => _dorryPosterML;
        public int MegamanPosterML => _megamanPosterML;
        public int RatmanPosterML => _ratmanPosterML;
        public int PridePosterML => _pridePosterML;
        public int Bomb3TruckT1 => _bomb3TruckT1;
        public int Bomb2TruckT1 => _bomb2TruckT1;
        public int Bomb4TruckT1 => _bomb4TruckT1;
        public int Bomb5TruckT1 => _bomb5TruckT1;
        public int Bomb1TruckT1 => _bomb1TruckT1;
        public int BeafschemaT2 => _beafschemaT2;
        public int BeafExtractorT2 => _beafExtractorT2;
        public int EastClocktowerLP => _eastClocktowerLP;
        public int SouthClocktowerLP => _southClocktowerLP;
        public int ClearanceSignLP => _clearanceSignLP;
        public int BikeAL => _bikeAL;
        public int FourPostersAL => _fourPostersAL;
        public int WeightMachineAL => _weightMachineAL;
        public int BodyBuildersAL => _bodyBuildersAL;
        public int FlexinSignAL => _flexinSignAL;
        public int RunningMachineAL => _runningMachineAL;
        public int BrandNewShoesAL => _brandNewShoesAL;
        public int OpticalGuyPosterAL => _opticalGuyPosterAL;
        public int CentralTacoFC => _centralTacoFC;
        public int DarkBeanFC => _darkBeanFC;
        public int TeresaOvenFC => _teresaOvenFC;
        public int EntranceDoorEP => _entranceDoorEP;
        public int TickyTheFoxCultist => _tickyTheFoxCultist;
        public int CampingTentEP => _campingTentEP;
        public int BulletinBoardSH => _bulletinBoardSH;
        public int CultistSignCultist => _cultistSignCultist;

        #endregion Properties
    }
}
