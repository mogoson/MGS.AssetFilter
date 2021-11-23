/*************************************************************************
 *  Copyright © 2021 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  AssetFilterSettings.cs
 *  Description  :  Define the specification of asset name.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  3/6/2018
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace MGS.AssetFilter
{
    [Serializable]
    public struct AssetPattern
    {
        public string assetType;
        public string namePattern;
        public string extensionPattern;

        public AssetPattern(string assetType, string namePattern, string extensionPattern)
        {
            this.assetType = assetType;
            this.namePattern = namePattern;
            this.extensionPattern = extensionPattern;
        }
    }

    public class AssetFilterSettings : ScriptableObject
    {
        #region Field and Property
        public List<AssetPattern> assetPatterns = new List<AssetPattern>()
        {
            new AssetPattern("Script", "^[A-Z]+[A-Za-z]+$", ".cs$|.js$"),
            new AssetPattern("Model", "^[A-Z]+[A-Za-z0-9]+$", ".fbx$|.obj$|.max$|.3ds$|.blend$|.dae$|.dxf$"),
            new AssetPattern("Material", "^[A-Z]+(_?[A-Za-z0-9]+)+$", ".mat$"),
            new AssetPattern("Texture", "^[A-Z]+(_?[A-Za-z0-9]+)+$", ".jpg$|.png$|.tga$|.bmp$|.psd$|.gif$|.iff$|.tiff$|.pict$")
        };
        #endregion
    }
}