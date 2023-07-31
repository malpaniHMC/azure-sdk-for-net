// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.ContentSafety
{
    /// <summary> The content or blob url of image, could be base64 encoding bytes or blob url. If both are given, the request will be refused. The maximum size of image is 2048 pixels * 2048 pixels, no larger than 4MB at the same time. The minimum size of image is 50 pixels * 50 pixels. </summary>
    public partial class ImageData
    {
        /// <summary> Initializes a new instance of ImageData. </summary>
        public ImageData()
        {
        }

        /// <summary> Initializes a new instance of ImageData. </summary>
        /// <param name="content"> Base64 encoding of image. </param>
        /// <param name="blobUrl"> The blob url of image. </param>
        internal ImageData(BinaryData content, Uri blobUrl)
        {
            Content = content;
            BlobUrl = blobUrl;
        }

        /// <summary>
        /// Base64 encoding of image.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Content { get; set; }
        /// <summary> The blob url of image. </summary>
        public Uri BlobUrl { get; set; }
    }
}
