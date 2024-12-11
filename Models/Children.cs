    public class UserInfo
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Punishment { get; set; }
        public bool ToiletPaperOutward { get; set; }
        public bool DonatesToCharity { get; set; }
        public bool WashesHands { get; set; }
        public string[]? MusicGenres { get; set; }
        public string? HomeAdress { get; set; }
        public string? CarModel { get; set; }
    }