using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Tango.Dance.Wonderful.Show.RNTangoDanceWonderfulShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTangoDanceWonderfulShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTangoDanceWonderfulShowModule"/>.
        /// </summary>
        internal RNTangoDanceWonderfulShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTangoDanceWonderfulShow";
            }
        }
    }
}
