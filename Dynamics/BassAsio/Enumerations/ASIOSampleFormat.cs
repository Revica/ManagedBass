﻿namespace ManagedBass.Dynamics
{
    /// <summary>
    /// BassAsio sample formats to be used with <see cref="AsioChannelInfo" /> and <see cref="BassAsio.ChannelGetInfo(bool,int,out AsioChannelInfo)" />.
    /// </summary>
    public enum AsioSampleFormat
    {
        /// <summary>
        /// Unknown format. Error.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// 16-bit integer.
        /// </summary>
        Bit16 = 16,

        /// <summary>
        /// 24-bit integer.
        /// </summary>
        Bit24 = 17,

        /// <summary>
        /// 32-bit integer.
        /// </summary>
        Bit32 = 18,

        /// <summary>
        /// 32-bit floating-point.
        /// </summary>
        Float = 19,

        /// <summary>
        /// DSD (LSB 1st)
        /// </summary>
        DSD_LSB = 32,

        /// <summary>
        /// DSD (MSB 1st)
        /// </summary>
        DSD_MSB = 33
    }
}