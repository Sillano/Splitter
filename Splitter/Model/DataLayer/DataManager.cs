using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model.DataLayer
{
    public class DataManager
    {
        private readonly SplitterContext context;

        public DataManager(SplitterContext context)
        {
            this.context = context;
        }

        public void AddProfile(Profile profile)
        {
            this.context.Add(profile);

            this.context.SaveChanges();
        }

        public Profile GetProfile(long profileId) => this.context.Profiles.First(x => x.Id == profileId);

        public long Login(string login, string password)
        {
            if (!this.context.Profiles.Any(x => x.Login == login && x.Password == password))
                throw new InvalidOperationException("Authentication credentials could are not valid");

            return this.context.Profiles.First(x => x.Login == login && x.Password == password).Id;
        }
    }
}
