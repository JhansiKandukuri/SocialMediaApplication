using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Custom Exception
/// </summary>
namespace SMA.Exception
{
    public class SocialMediaException : ApplicationException
    {
        public SocialMediaException() : base()
        {

        }
        public SocialMediaException(string errorMsg) : base()
        {

        }
    }
}
