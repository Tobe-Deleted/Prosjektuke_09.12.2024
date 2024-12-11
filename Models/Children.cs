    public class UserInfo
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public bool ToiletPaperOutward { get; set; }
        public bool DonatesToCharity { get; set; }
        public bool WashesHands { get; set; }
        public required string[] MusicGenres { get; set; }
        public required string HomeAdress { get; set; }
        public required string CarModel { get; set; }
    
        public Elves? Elf { get; set; }
        public string? Gift { get; set; }
    
    }