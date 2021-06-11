using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Services.Data
{
    public class AdvertentieRepository
    {
        private readonly ConfigRepository _configRepo;
        private readonly Uri _adBaseUri;


        private readonly List<string> _advertentiePaden;
        private List<string>.Enumerator _adEnumerator;

        public AdvertentieRepository()
        {
            _configRepo = new ConfigRepository();
            // TODO: tied to local filesystem, needs to be independent of location -->
            //_adBaseUri = new Uri(_configRepo.GetValue<string>("BaseUriAds"));
            //_advertentiePaden = new List<string>(Directory.GetFiles(_adBaseUri.LocalPath));



            _advertentiePaden = new List<string>(Directory.GetFiles("../../../Resources/Pictures/"));
            _adEnumerator = _advertentiePaden.GetEnumerator();

        }

        public string GetNextAdPath()
        {

            if (!_adEnumerator.MoveNext())
            {
                _adEnumerator = _advertentiePaden.GetEnumerator();
                _adEnumerator.MoveNext();
            }
            return _adEnumerator.Current;

        }

        /*public Uri GetNextAdUri()*/
        public string GetNextAdUri()
        {
            if (!_adEnumerator.MoveNext())
            {
                _adEnumerator = _advertentiePaden.GetEnumerator();
                _adEnumerator.MoveNext();
            }
            var currAdPath = _adEnumerator.Current;
            /*return new Uri(currAdPath);*/
            return currAdPath;
        }


    }
}
