using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRK.Mp3MetaEditor
{
    public class RenameProgress
    {
        public RenameProgress(int TotalCount,int RenamedCount, string RenameState ,string ErrorMessage="") {
            _totalFilesCount = TotalCount;
            _renamedFilesCount = RenamedCount;
            _renameStatus = RenameState;
            _errorMessage = ErrorMessage;
        }

        public int _totalFilesCount;
        public int _renamedFilesCount;
        public string _renameStatus;
        public string _errorMessage;
    }

     
}
