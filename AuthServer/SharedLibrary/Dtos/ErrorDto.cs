using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        //Burda hatalar tutulur.
        public List<String> Errors { get; private set; } = new List<string>();

        //Burda hatanın Kkullanıcıya gösterilip gösterilmeyeceğine karar verilir.
        public bool IsShow { get; private set; }

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
