using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public interface Asn1TaggedObjectParser
		: IAsn1Convertible
	{
        int TagClass { get; }

		int TagNo { get; }

        bool HasContextTag(int tagNo);

        bool HasTag(int tagClass, int tagNo);

        /// <exception cref="IOException"/>
        [Obsolete("Use 'Parse...' methods instead, after checking this parser's TagClass and TagNo")]
        IAsn1Convertible GetObjectParser(int tag, bool isExplicit);

        /// <exception cref="IOException"/>
        IAsn1Convertible ParseBaseUniversal(bool declaredExplicit, int baseTagNo);

        /// <exception cref="IOException"/>
        Asn1TaggedObjectParser ParseExplicitBaseTagged();

        /// <exception cref="IOException"/>
        Asn1TaggedObjectParser ParseImplicitBaseTagged(int baseTagClass, int baseTagNo);
    }
}
