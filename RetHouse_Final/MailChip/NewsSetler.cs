using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailChimp.Net;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System.Globalization;
using MailChimp.Net.Interfaces;

namespace RetHouse_Final.MailChip
{

    public class MailchimpRepository
    {
        private const string ApiKey = "34d850695f57809dca2bde0358a8eb63-us17";
        private const string ListId = "e821ab3387";
        private IMailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);

        // `html` contains the content of your email using html notation
        public async void CreateAndSendCampaign(string html)
        {
            var member = new Member { EmailAddress = html , StatusIfNew = Status.Subscribed };
            member.MergeFields.Add("FNAME", "HOLY");
            member.MergeFields.Add("LNAME", "COW");
            await _mailChimpManager.Members.AddOrUpdateAsync(ListId, member);
        }
        public List<List> GetAllMailingLists()
          => _mailChimpManager.Lists.GetAllAsync().Result.ToList();

    }
}
