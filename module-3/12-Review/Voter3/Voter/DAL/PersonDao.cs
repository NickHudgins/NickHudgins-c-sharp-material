using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voter.Models;

namespace Voter.DAL
{
    public class VoterDao
    {
        string connectionString;

        public VoterDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Voter> GetVoters()
        {
            List<Voter> voters = new List<Voter>;
            return voters;
        }
        
    }
}
