// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.Kinect.Sensor
{
    [Native.NativeReference("k4a_wired_sync_mode_t")]
    public enum WiredSyncMode
    {
        Standalone,
        Master,
        Subordinate
    }
}
