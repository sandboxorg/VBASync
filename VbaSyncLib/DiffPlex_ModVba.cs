﻿/* This file contains various parts of the DiffPlex package, modified for use with VBA.
 * All modifications to the DiffPlex code are licensed under the following terms:
 * 
 * * Copyright (c) 2016 Chelsea Hughes
 * *
 * * You may use this software for any purpose and alter it freely. You may redistribute it
 * * subject to these restrictions:
 * *
 * * (a) You must not misrepresent the software's original authorship.
 * * (b) Altered versions must be clearly marked as such, in a way visible to a typical user,
 * *     and must not be misrepresented as the original.
 * * (c) This notice must remain intact in any source code distribution.
 * *
 * * This software is provided "as-is," without any express or implied warranty. In no event
 * * will the author be held liable for any damages arising from the use of this software.
 * 
 * DiffPlex is distributed under the Apache License, included below:
 * 
 * * Apache License
 * * Version 2.0, January 2004
 * * http://www.apache.org/licenses/
 * *
 * * TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION
 * *
 * * 1. Definitions.
 * *
 * * "License" shall mean the terms and conditions for use, reproduction, and distribution as defined by Sections 1 through 9 of this document.
 * *
 * * "Licensor" shall mean the copyright owner or entity authorized by the copyright owner that is granting the License.
 * *
 * * "Legal Entity" shall mean the union of the acting entity and all other entities that control, are controlled by, or are under common control
 * * with that entity. For the purposes of this definition, "control" means (i) the power, direct or indirect, to cause the direction or management
 * * of such entity, whether by contract or otherwise, or (ii) ownership of fifty percent (50%) or more of the outstanding shares, or
 * * (iii) beneficial ownership of such entity.
 * *
 * * "You" (or "Your") shall mean an individual or Legal Entity exercising permissions granted by this License.
 * *
 * * "Source" form shall mean the preferred form for making modifications, including but not limited to software source code, documentation source,
 * * and configuration files.
 * *
 * * "Object" form shall mean any form resulting from mechanical transformation or translation of a Source form, including but not limited to
 * * compiled object code, generated documentation, and conversions to other media types.
 * *
 * * "Work" shall mean the work of authorship, whether in Source or Object form, made available under the License, as indicated by a copyright notice
 * * that is included in or attached to the work (an example is provided in the Appendix below).
 * *
 * * "Derivative Works" shall mean any work, whether in Source or Object form, that is based on (or derived from) the Work and for which the editorial
 * * revisions, annotations, elaborations, or other modifications represent, as a whole, an original work of authorship. For the purposes of this License,
 * * Derivative Works shall not include works that remain separable from, or merely link (or bind by name) to the interfaces of, the Work and
 * * Derivative Works thereof.
 * *
 * * "Contribution" shall mean any work of authorship, including the original version of the Work and any modifications or additions to that Work or
 * * Derivative Works thereof, that is intentionally submitted to Licensor for inclusion in the Work by the copyright owner or by an individual or
 * * Legal Entity authorized to submit on behalf of the copyright owner. For the purposes of this definition, "submitted" means any form of electronic,
 * * verbal, or written communication sent to the Licensor or its representatives, including but not limited to communication on electronic mailing lists,
 * * source code control systems, and issue tracking systems that are managed by, or on behalf of, the Licensor for the purpose of discussing and
 * * improving the Work, but excluding communication that is conspicuously marked or otherwise designated in writing by the copyright owner as
 * * "Not a Contribution."
 * *
 * * "Contributor" shall mean Licensor and any individual or Legal Entity on behalf of whom a Contribution has been received by Licensor and subsequently
 * * incorporated within the Work.
 * *
 * * 2. Grant of Copyright License.
 * *
 * * Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free,
 * * irrevocable copyright license to reproduce, prepare Derivative Works of, publicly display, publicly perform, sublicense, and distribute the Work and such
 * * Derivative Works in Source or Object form.
 * *
 * * 3. Grant of Patent License.
 * *
 * * Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free,
 * * irrevocable (except as stated in this section) patent license to make, have made, use, offer to sell, sell, import, and otherwise transfer the Work,
 * * where such license applies only to those patent claims licensable by such Contributor that are necessarily infringed by their Contribution(s) alone or
 * * by combination of their Contribution(s) with the Work to which such Contribution(s) was submitted. If You institute patent litigation against any entity
 * * (including a cross-claim or counterclaim in a lawsuit) alleging that the Work or a Contribution incorporated within the Work constitutes direct or
 * * contributory patent infringement, then any patent licenses granted to You under this License for that Work shall terminate as of the date such litigation
 * * is filed.
 * *
 * * 4. Redistribution.
 * *
 * * You may reproduce and distribute copies of the Work or Derivative Works thereof in any medium, with or without modifications, and in Source or Object form,
 * * provided that You meet the following conditions:
 * *
 * * You must give any other recipients of the Work or Derivative Works a copy of this License; and
 * * You must cause any modified files to carry prominent notices stating that You changed the files; and
 * * You must retain, in the Source form of any Derivative Works that You distribute, all copyright, patent, trademark, and attribution notices from the Source
 * *     form of the Work, excluding those notices that do not pertain to any part of the Derivative Works; and
 * * If the Work includes a "NOTICE" text file as part of its distribution, then any Derivative Works that You distribute must include a readable copy of the
 * *     attribution notices contained within such NOTICE file, excluding those notices that do not pertain to any part of the Derivative Works, in at least one of
 * *     the following places: within a NOTICE text file distributed as part of the Derivative Works; within the Source form or documentation, if provided along
 * *     with the Derivative Works; or, within a display generated by the Derivative Works, if and wherever such third-party notices normally appear. The contents
 * *     of the NOTICE file are for informational purposes only and do not modify the License. You may add Your own attribution notices within Derivative Works
 * *     that You distribute, alongside or as an addendum to the NOTICE text from the Work, provided that such additional attribution notices cannot be construed
 * *     as modifying the License.
 * * You may add Your own copyright statement to Your modifications and may provide additional or different license terms and conditions for use, reproduction,
 * * or distribution of Your modifications, or for any such Derivative Works as a whole, provided Your use, reproduction, and distribution of the Work otherwise
 * * complies with the conditions stated in this License.
 * *
 * * 5. Submission of Contributions.
 * *
 * * Unless You explicitly state otherwise, any Contribution intentionally submitted for inclusion in the Work by You to the Licensor shall be under the terms
 * * and conditions of this License, without any additional terms or conditions. Notwithstanding the above, nothing herein shall supersede or modify the terms
 * * of any separate license agreement you may have executed with Licensor regarding such Contributions.
 * *
 * * 6. Trademarks.
 * *
 * * This License does not grant permission to use the trade names, trademarks, service marks, or product names of the Licensor, except as required for
 * * reasonable and customary use in describing the origin of the Work and reproducing the content of the NOTICE file.
 * *
 * * 7. Disclaimer of Warranty.
 * *
 * * Unless required by applicable law or agreed to in writing, Licensor provides the Work (and each Contributor provides its Contributions) on an "AS IS" BASIS,
 * * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied, including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT,
 * * MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE. You are solely responsible for determining the appropriateness of using or redistributing the Work and
 * * assume any risks associated with Your exercise of permissions under this License.
 * *
 * * 8. Limitation of Liability.
 * *
 * * In no event and under no legal theory, whether in tort (including negligence), contract, or otherwise, unless required by applicable law (such as deliberate
 * * and grossly negligent acts) or agreed to in writing, shall any Contributor be liable to You for damages, including any direct, indirect, special, incidental,
 * * or consequential damages of any character arising as a result of this License or out of the use or inability to use the Work (including but not limited to
 * * damages for loss of goodwill, work stoppage, computer failure or malfunction, or any and all other commercial damages or losses), even if such Contributor
 * * has been advised of the possibility of such damages.
 * *
 * * 9. Accepting Warranty or Additional Liability.
 * *
 * * While redistributing the Work or Derivative Works thereof, You may choose to offer, and charge a fee for, acceptance of support, warranty, indemnity, or other
 * * liability obligations and/or rights consistent with this License. However, in accepting such obligations, You may act only on Your own behalf and on Your sole
 * * responsibility, not on behalf of any other Contributor, and only if You agree to indemnify, defend, and hold each Contributor harmless for any liability
 * * incurred by, or claims asserted against, such Contributor by reason of your accepting any such warranty or additional liability.
 * *
 * * END OF TERMS AND CONDITIONS
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace VbaSync {
    static class VbaDiffer {
        public static DiffResult CreateVbaDiffs(string oldText, string newText) {
            if (oldText == null)
                throw new ArgumentNullException(nameof(oldText));
            if (newText == null)
                throw new ArgumentNullException(nameof(newText));

            var pieceHash = new Dictionary<string, int>();
            var lineDiffs = new List<DiffBlock>();

            var modOld = new ModificationData(oldText);
            var modNew = new ModificationData(newText);

            BuildPieceHashes(pieceHash, modOld);
            BuildPieceHashes(pieceHash, modNew);

            BuildModificationData(modOld, modNew);

            var piecesALength = modOld.HashedPieces.Length;
            var piecesBLength = modNew.HashedPieces.Length;
            var posA = 0;
            var posB = 0;

            do {
                while (posA < piecesALength
                       && posB < piecesBLength
                       && !modOld.Modifications[posA]
                       && !modNew.Modifications[posB]) {
                    posA++;
                    posB++;
                }

                var beginA = posA;
                var beginB = posB;

                while (posA < piecesALength && modOld.Modifications[posA])
                    posA++;

                while (posB < piecesBLength && modNew.Modifications[posB])
                    posB++;

                var deleteCount = posA - beginA;
                var insertCount = posB - beginB;
                if (deleteCount > 0 || insertCount > 0) {
                    lineDiffs.Add(new DiffBlock(beginA, deleteCount, beginB, insertCount));
                }
            } while (posA < piecesALength && posB < piecesBLength);

            return new DiffResult(modOld.Pieces, modNew.Pieces, lineDiffs);
        }

        static EditLengthResult CalculateEditLength(int[] a, int startA, int endA, int[] b, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal) {
            if (null == a)
                throw new ArgumentNullException(nameof(a));
            if (null == b)
                throw new ArgumentNullException(nameof(b));

            if (a.Length == 0 && b.Length == 0) {
                return new EditLengthResult();
            }

            var n = endA - startA;
            var m = endB - startB;
            var max = m + n + 1;
            var half = max / 2;
            var delta = n - m;
            var deltaEven = delta % 2 == 0;
            forwardDiagonal[1 + half] = 0;
            reverseDiagonal[1 + half] = n + 1;

            for (var d = 0; d <= half; d++) {
                // forward D-path
                Edit lastEdit;
                for (var k = -d; k <= d; k += 2) {
                    var kIndex = k + half;
                    int x;
                    if (k == -d || (k != d && forwardDiagonal[kIndex - 1] < forwardDiagonal[kIndex + 1])) {
                        x = forwardDiagonal[kIndex + 1]; // y up    move down from previous diagonal
                        lastEdit = Edit.InsertDown;
                    } else {
                        x = forwardDiagonal[kIndex - 1] + 1; // x up     move right from previous diagonal
                        lastEdit = Edit.DeleteRight;
                    }
                    var y = x - k;
                    var startX = x;
                    var startY = y;
                    while (x < n && y < m && a[x + startA] == b[y + startB]) {
                        x += 1;
                        y += 1;
                    }

                    forwardDiagonal[kIndex] = x;

                    if (!deltaEven) {
                        if (k - delta >= -d + 1 && k - delta <= d - 1) {
                            var revKIndex = k - delta + half;
                            var revX = reverseDiagonal[revKIndex];
                            var revY = revX - k;
                            if (revX <= x && revY <= y) {
                                return new EditLengthResult {
                                    EditLength = 2*d - 1,
                                    StartX = startX + startA,
                                    StartY = startY + startB,
                                    EndX = x + startA,
                                    EndY = y + startB,
                                    LastEdit = lastEdit
                                };
                            }
                        }
                    }
                }

                // reverse D-path
                for (var k = -d; k <= d; k += 2) {
                    var kIndex = k + half;
                    int x;
                    if (k == -d || (k != d && reverseDiagonal[kIndex + 1] <= reverseDiagonal[kIndex - 1])) {
                        x = reverseDiagonal[kIndex + 1] - 1; // move left from k+1 diagonal
                        lastEdit = Edit.DeleteLeft;
                    } else {
                        x = reverseDiagonal[kIndex - 1]; //move up from k-1 diagonal
                        lastEdit = Edit.InsertUp;
                    }
                    var y = x - (k + delta);

                    var endX = x;
                    var endY = y;
                    
                    while (x > 0 && y > 0 && a[startA + x - 1] == b[startB + y - 1]) {
                        x -= 1;
                        y -= 1;
                    }
                    
                    reverseDiagonal[kIndex] = x;

                    if (deltaEven) {
                        if (k + delta >= -d && k + delta <= d) {
                            var forKIndex = k + delta + half;
                            var forX = forwardDiagonal[forKIndex];
                            var forY = forX - (k + delta);
                            if (forX >= x && forY >= y) {
                                return new EditLengthResult {
                                    EditLength = 2*d,
                                    StartX = x + startA,
                                    StartY = y + startB,
                                    EndX = endX + startA,
                                    EndY = endY + startB,
                                    LastEdit = lastEdit
                                };
                            }
                        }
                    }
                }
            }
            
            throw new Exception("Should never get here");
        }

        static void BuildModificationData(ModificationData a, ModificationData b) {
            var n = a.HashedPieces.Length;
            var m = b.HashedPieces.Length;
            var max = m + n + 1;
            var forwardDiagonal = new int[max + 1];
            var reverseDiagonal = new int[max + 1];
            BuildModificationData(a, 0, n, b, 0, m, forwardDiagonal, reverseDiagonal);
        }

        static void BuildModificationData(ModificationData a, int startA, int endA, ModificationData b, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal) {

            while (startA < endA && startB < endB && a.HashedPieces[startA].Equals(b.HashedPieces[startB])) {
                startA++;
                startB++;
            }
            while (startA < endA && startB < endB && a.HashedPieces[endA - 1].Equals(b.HashedPieces[endB - 1])) {
                endA--;
                endB--;
            }

            int aLength = endA - startA;
            int bLength = endB - startB;
            if (aLength > 0 && bLength > 0) {
                EditLengthResult res = CalculateEditLength(a.HashedPieces, startA, endA, b.HashedPieces, startB, endB, forwardDiagonal, reverseDiagonal);
                if (res.EditLength <= 0)
                    return;

                if (res.LastEdit == Edit.DeleteRight && res.StartX - 1 > startA)
                    a.Modifications[--res.StartX] = true;
                else if (res.LastEdit == Edit.InsertDown && res.StartY - 1 > startB)
                    b.Modifications[--res.StartY] = true;
                else if (res.LastEdit == Edit.DeleteLeft && res.EndX < endA)
                    a.Modifications[res.EndX++] = true;
                else if (res.LastEdit == Edit.InsertUp && res.EndY < endB)
                    b.Modifications[res.EndY++] = true;

                BuildModificationData(a, startA, res.StartX, b, startB, res.StartY, forwardDiagonal, reverseDiagonal);
                BuildModificationData(a, res.EndX, endA, b, res.EndY, endB, forwardDiagonal, reverseDiagonal);
            } else if (aLength > 0) {
                for (var i = startA; i < endA; i++)
                    a.Modifications[i] = true;
            } else if (bLength > 0) {
                for (var i = startB; i < endB; i++)
                    b.Modifications[i] = true;
            }
        }

        static void BuildPieceHashes(IDictionary<string, int> pieceHash, ModificationData data) {
            var pieces = string.IsNullOrEmpty(data.RawData) ? new string[0] : data.RawData.Split(new [] {"\r\n"}, StringSplitOptions.None);

            data.Pieces = pieces;
            data.HashedPieces = new int[pieces.Length];
            data.Modifications = new bool[pieces.Length];

            var startInComment = false;
            for (var i = 0; i < pieces.Length; i++) {
                var piece = UppercaseVbaSymbols(pieces[i], ref startInComment);

                if (pieceHash.ContainsKey(piece)) {
                    data.HashedPieces[i] = pieceHash[piece];
                } else {
                    data.HashedPieces[i] = pieceHash.Count;
                    pieceHash[piece] = pieceHash.Count;
                }
            }
        }

        static string UppercaseVbaSymbols(string s, ref bool startInComment) {
            var sb = new StringBuilder(s.Length);
            var ls = startInComment ? LineState.Comment : LineState.New;
            startInComment = false;
            for (var i = 0; i < s.Length; i++) {
                if (ls == LineState.Quoted || ls == LineState.Comment) {
                    sb.Append(s[i]);
                } else {
                    sb.Append(char.ToUpper(s[i]));
                }
                switch (s[i]) {
                    case '"':
                        if (ls != LineState.Comment) {
                            ls = ls == LineState.Quoted ? LineState.Normal : LineState.Quoted;
                        }
                        break;
                    case '\'':
                        if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Comment;
                        }
                        break;
                    case ':':
                        if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.New;
                        }
                        break;
                    case 'R':
                    case 'r':
                        if (ls == LineState.New) {
                            ls = LineState.CommentAwaitE;
                        } else if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Normal;
                        }
                        break;
                    case 'E':
                    case 'e':
                        if (ls == LineState.CommentAwaitE) {
                            ls = LineState.CommentAwaitM;
                        } else if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Normal;
                        }
                        break;
                    case 'M':
                    case 'm':
                        if (ls == LineState.CommentAwaitM) {
                            ls = LineState.CommentAwaitSpace;
                        } else if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Normal;
                        }
                        break;
                    case ' ':
                        if (ls == LineState.CommentAwaitSpace) {
                            ls = LineState.Comment;
                        } else if (ls != LineState.Quoted && ls != LineState.Comment && ls != LineState.New) {
                            ls = LineState.Normal;
                        }
                        break;
                    case '_':
                        if (ls == LineState.Comment && i > 0 && i == s.Length - 1 && s[i - 1] == ' ') {
                            startInComment = true;
                        } else if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Normal;
                        }
                        break;
                    default:
                        if (ls != LineState.Quoted && ls != LineState.Comment) {
                            ls = LineState.Normal;
                        }
                        break;
                }
            }
            return sb.ToString();
        }
    }

    class DiffBlock {
        public int DeleteStartA { get; }
        public int DeleteCountA { get; }
        public int InsertStartB { get; }
        public int InsertCountB { get; }

        public DiffBlock(int deleteStartA, int deleteCountA, int insertStartB, int insertCountB) {
            DeleteStartA = deleteStartA;
            DeleteCountA = deleteCountA;
            InsertStartB = insertStartB;
            InsertCountB = insertCountB;
        }
    }

    class DiffResult {
        public string[] PiecesOld { get; }
        public string[] PiecesNew { get; }
        public IList<DiffBlock> DiffBlocks { get; }

        public DiffResult(string[] peicesOld, string[] piecesNew, IList<DiffBlock> blocks) {
            PiecesOld = peicesOld;
            PiecesNew = piecesNew;
            DiffBlocks = blocks;
        }
    }

    enum Edit {
        None,
        DeleteRight,
        DeleteLeft,
        InsertDown,
        InsertUp
    }

    class EditLengthResult {
        public int EditLength { get; set; }

        public int StartX { get; set; }
        public int EndX { get; set; }
        public int StartY { get; set; }
        public int EndY { get; set; }

        public Edit LastEdit { get; set; }
    }

    class ModificationData {
        public int[] HashedPieces { get; set; }
        public string RawData { get; }
        public bool[] Modifications { get; set; }
        public string[] Pieces { get; set; }

        public ModificationData(string str) {
            RawData = str;
        }
    }

    enum LineState {
        New,
        Normal,
        Quoted,
        Comment,
        CommentAwaitE,
        CommentAwaitM,
        CommentAwaitSpace
    }
}