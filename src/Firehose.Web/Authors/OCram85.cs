using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
   public class OCram85 : IAmACommunityMember
    {
        public string FirstName => "Marco";
        public string LastName => "Blessing";
        public string ShortBioOrTagLine => "DevOps, Automation, Style Guide Enthusiast";
        public string StateOrRegion => "Karlsruhe, Germany";
        public string EmailAddress => "marco.blessing@googlemail.com";
        public string TwitterHandle => "tar_honar";
        public string GravatarHash => "3a8ff94ca91ae5af9d989511c2b63bb4";
        public string GitHubHandle => "OCram85";
        public GeoPosition Position => new GeoPosition(49.006889, 8.403653);

        public Uri WebSite => new Uri("https://OCram85.github.io/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://OCram85.github.io/feed"); } }
    }
}
