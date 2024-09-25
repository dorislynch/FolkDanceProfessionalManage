using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Folk.Dance.Professional.Manage.RNFolkDanceProfessionalManage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFolkDanceProfessionalManageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFolkDanceProfessionalManageModule"/>.
        /// </summary>
        internal RNFolkDanceProfessionalManageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFolkDanceProfessionalManage";
            }
        }
    }
}
