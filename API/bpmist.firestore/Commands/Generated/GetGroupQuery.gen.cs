using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bpmist.common.Commands;
using bpmist.data.ICommands;

namespace bpmist.firestore.Commands
{
    public partial class GetGroupQuery :
    Command<GetGroupParameter, GetGroupResult>, IGetGroupQuery
    {
        public GetGroupQuery(
            
        )
        {


            this.InitializeAfterConstruction();
        }


    }
}
