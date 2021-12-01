﻿using XDM.Core.Lib.Common;

namespace XDM.Core.Lib.Common
{
    public interface ICancelRequster
    {
        public ErrorCode Error { get; }

        void CancelWithFatal(ErrorCode error);
        void NotifyTransientFailure();
        void RegisterThread(HttpChunkDownloader chunkDownloader);
        void UnRegisterThread(HttpChunkDownloader chunkDownloader);
        void CancelAll();
    }
}