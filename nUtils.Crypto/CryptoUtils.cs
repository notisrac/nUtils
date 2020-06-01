using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nUtils.Crypto
{
    public class CryptoUtils
    {
        static byte[] _baEntropy = Encoding.UTF8.GetBytes("2/4vcs#t=NhVgE)w6C&JxBBc+/*R@`4TnX%]#y?&tGGB>3EqK&X4}Fa:Wm-f9Q*J.>mS!J#E[y#3s!x[;ZRMwva*D7@;.D5QVPXHM<WR_NL4,T42KpZ2km[D=z5PnzwC>z[6^Nz/.!rN9>Y9yL~[y[h/Q:CLn7z6ncXQ&f`.``%qde3w&h+dpJ:N%9L#C]68ax~(y&@ukd!A4%}+`[hA6t-fB(h#CKQxv-}Ebrj`S~qw<Y5z#^Ux_D{z!E'H4P-TfGgL#7D&k<9{KvZDYb'edF/@Xq;Ejk}G(3Lz~Zd6`_nmh!:Y@ynUf',)k?`j+&THp8y;7R}m/K<CkDUDg,A>v*T5B[nK}MPTy#>G:Vrt=fMjy&}_<h7TE&#!6AbEe8vUFyq{q)_}V*!crVxem2mq]ZJdR;A&%S%X]}Bes8T/S-S_7'+uPz/t}x<2>mp,zRM=r@]+t[9q/C,;*?>%A}Z^d&GFtW[U#2!C6pT(U@,$2)X'8Ug~kwLD2@k[xupEFVM3RzZ]T8jj&[N#U@#hudC:yLw~dtU{[w%5PN[Weyv!h5ahQ+*D$2rD`j$Kt]./U%s]J{UZqy#c7==gfHD/@KYWC%2R<{/K2{dkk$Hf2FR^,Zp;dnX`SCKL+kD{?pD-F{.]%{NV,][*Q%q':~HsruFa6[z!4#sZ=&2N$gW+w5+__v!?Tcpy[U<MVfKsaVB]db/f&UHNs>Tky]y{*=%+mWS2B*Cvxb]B/`C+Fy@+nC(rVGKX']$'mRM+4f5gM'c^Tz6yDxrdny(N3K3&qWV2#E<_NxB@xRkxwKz;(%DAx'<agM#}{ZrrczxqwQ!J'FN&K7frGdAfeZX/+`B-Y!Sh>j)%e@u%>B/ZdP:TYt+W6BA~;~5$tkTw3n]`&n<sfE!sV%d72(E<GRM$<?(F6-x`yr=4UTcgkam=!kftSy4AXP4;a;J3&'@'D]#Lxry[Lq#v^h)y]d?#-^M,+W9e',s?jjX#K_K#99?*6$vE$Tqn&YbS,NFy+~yV4g5vP#u9BQJdS}a35}4#N}dZ8F!Y-KbJjj>3/{s#rnqZ&~TDv<gzK7&jq(5)$7X];V:Bcq;p.CMcjD6(-'X;Nw)th?NhW26USCTZ<}!G-a''Ug$m{R@:DY}J!sQN`/2-RACmU,3+azGy`+NwZ4u[j[Z9?^Kk)~`:2C<}{):L)E>B[QkzTetbF<)f,9fwcu/q4zpvjkkV?Uf`>'{qFW'%C=B}yh#MK?_p,VxFT9rkyD?v^mxTbBG/*3S?+Rj'h@+#gqjPsr~!/)vu=:BS(9djV$$L%<`/@TH?Wrtqq.gyAHd#PEyT<jQcaG%#*fjc`BqN^p?;?=?!!b@ENs[Qqt<TGZ)#V^QDVp-j}*Q3&&kmGr@J9N._&Cu9<%M8DW.aeuT22dgdM'E(]2Hc:mtU6)w87*b[Gb7c=!Q{^$**P<{D}<r2~mqKs+HmGP$J!7GW_)YqsU/!yq6r8j-J&+H}9'cU#f*Dd9wZy}]M=crxuHqz`7FXF%mJhF.)_hnZQqdA/!zzAfjf[]y[WXnFFY;e^A7@pzz_Mb:sD6UhED>>w;pd7^YGT#`4ZU}^)>R#'>R$Zna]sVK3<#h]tg?U}[2:W<*3Q[ynxA&}5A7zC%28.2>'7f%UA?}Cg:`g{K&n2v&PLz;N)=Em@@K]Y3e7r^C<q;`gbE)RqEfMgTRA4ueBfk8`mz&W#9{/4s^)2%=`KLewCUU_(v<>NJH6LUyQX7gb(Hgv5VA&5g-_>U*bc,=By@p?'J,%fT)MkN>?9Z*jT3SPB~*9j~uLqMZ{4q%vk@gdJ{@BMSkF45)x%D~8QfR&AcrAb(Z!dFQH`[P!<eD*e4?!CUT-v.Zmus&w7?.wMzcm*gH79k((b?uTqW(&mNp,h?#up;=>kyU@(zv+}z~`GvMgwT#jp>a?T5XW{KDN+FA+hg)[?B&~nyw-,-}gjfzsAkkSnXA(DR/&!Kw9e'gWaz&}mj()Myctf7>%vyFHC)z[Gv.{u!L_G>X5y3=shv~}GtUd6=@]#MU7hza3$~AsKF.%k>}fw']^p<c}K&Rj,brr#");

        public static string EncryptString(string input)
        {
            return EncryptString(Encoding.UTF8.GetBytes(input));
        }

        public static string EncryptString(byte[] input)
        {
            byte[] baEncryptedData = ProtectedData.Protect(input, _baEntropy, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(baEncryptedData);
        }

        public static string DecryptString(string input)
        {
            try
            {
                byte[] baDecryptedData = ProtectedData.Unprotect(Convert.FromBase64String(input), _baEntropy, DataProtectionScope.CurrentUser);

                return Encoding.UTF8.GetString(baDecryptedData);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string ROT13(string input)
        { // http://stackoverflow.com/a/18739120
            return !string.IsNullOrEmpty(input) ? new string(input.ToCharArray().Select(s => { return (char)((s >= 97 && s <= 122) ? ((s + 13 > 122) ? s - 13 : s + 13) : (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); }).ToArray()) : input;
        }

        public static string SimpleEncrypt(string input)
        {
            return SimpleEncrypt(Encoding.UTF8.GetBytes(input));
        }

        public static string SimpleEncrypt(byte[] input)
        {
            return ROT13(Convert.ToBase64String(input));
        }

        public static string SimpleDecrypt(string input)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(ROT13(input)));
        }
    }
}
