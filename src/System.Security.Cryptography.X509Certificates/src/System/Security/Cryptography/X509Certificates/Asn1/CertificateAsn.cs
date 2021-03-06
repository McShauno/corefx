// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.X509Certificates.Asn1
{
    // https://tools.ietf.org/html/rfc5280#section-4.1
    //
    // Certificate  ::=  SEQUENCE  {
    //     tbsCertificate       TBSCertificate,
    //     signatureAlgorithm   AlgorithmIdentifier,
    //     signatureValue       BIT STRING
    // }
    [StructLayout(LayoutKind.Sequential)]
    internal sealed class CertificateAsn
    {
        internal TbsCertificateAsn TbsCertificate;

        internal AlgorithmIdentifierAsn SignatureAlgorithm;

        [BitString]
        internal ReadOnlyMemory<byte> SignatureValue;
    }
}
