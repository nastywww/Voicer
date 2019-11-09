using System;

namespace BusinessLogicLayer.Abstraction.Services.Voting
{
    public class VotingDto
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
    }
}