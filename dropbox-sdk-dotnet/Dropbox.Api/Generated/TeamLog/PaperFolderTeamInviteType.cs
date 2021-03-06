// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The paper folder team invite type object</para>
    /// </summary>
    public class PaperFolderTeamInviteType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperFolderTeamInviteType> Encoder = new PaperFolderTeamInviteTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperFolderTeamInviteType> Decoder = new PaperFolderTeamInviteTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperFolderTeamInviteType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public PaperFolderTeamInviteType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperFolderTeamInviteType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperFolderTeamInviteType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the paper folder team invite type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperFolderTeamInviteType" />.</para>
        /// </summary>
        private class PaperFolderTeamInviteTypeEncoder : enc.StructEncoder<PaperFolderTeamInviteType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperFolderTeamInviteType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperFolderTeamInviteType" />.</para>
        /// </summary>
        private class PaperFolderTeamInviteTypeDecoder : enc.StructDecoder<PaperFolderTeamInviteType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperFolderTeamInviteType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperFolderTeamInviteType Create()
            {
                return new PaperFolderTeamInviteType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperFolderTeamInviteType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
