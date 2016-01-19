using Newtonsoft.Json;

namespace HeroesStaffingAgency.Models
{
    public class Hero
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        
        [JsonProperty(PropertyName="sex")]
        public string Sex { get; set; }
        
        [JsonProperty(PropertyName="pseudonym")]
        public string Pseudonym { get; set; }
        
        [JsonProperty(PropertyName="firstName")]
        public string FirstName { get; set; }
        
        [JsonProperty(PropertyName="lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "photo")]
        public string Photo { get; set; }
    }
}