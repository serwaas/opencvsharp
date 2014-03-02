﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCvSharp.CPlusPlus
{
#if LANG_JP
    /// <summary>
    /// cv::dct の変換フラグ
    /// </summary>
#else
    /// <summary>
    /// Transformation flags for cv::dct
    /// </summary>
#endif
    [Flags]
    public enum DctFlag2
    {
#if LANG_JP
        /// <summary>
        /// Zero
        /// [0]
        /// </summary>
#else
        /// <summary>
        /// Zero
        /// [0]
        /// </summary>
#endif
        None = 0,


#if LANG_JP
        /// <summary>
        /// 1次元または2次元の逆変換を行う．結果のスケーリングは行わない． 
        /// Forward と Inverse は，もちろん同時には指定できない．
        /// [DFT_INVERSE]
        /// </summary>
#else
        /// <summary>
        /// Do inverse 1D or 2D transform.
        /// (Forward and Inverse are mutually exclusive, of course.)
        /// [DFT_INVERSE]
        /// </summary>
#endif
        Inverse = CppConst.DFT_INVERSE,


#if LANG_JP
        /// <summary>
        /// 入力配列のそれぞれの行に対して独立に，順変換あるいは逆変換を行う． 
        /// このフラグは複数のベクトルの同時変換を許可し，
        /// オーバーヘッド（一つの計算の何倍も大きくなることもある）を減らすためや，
        /// 3次元以上の高次元に対して変換を行うために使用される．
        /// [DFT_ROWS]
        /// </summary>
#else
        /// <summary>
        /// Do forward or inverse transform of every individual row of the input matrix. 
        /// This flag allows user to transform multiple vectors simultaneously and can be used to decrease the overhead 
        /// (which is sometimes several times larger than the processing itself), to do 3D and higher-dimensional transforms etc. 
        /// [DFT_ROWS]
        /// </summary>
#endif
        Rows = CppConst.DFT_ROWS,
    }
}
