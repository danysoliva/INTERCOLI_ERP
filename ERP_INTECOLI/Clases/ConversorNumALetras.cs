using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_INTECOLI.Clases
{
    public class ConversorNumALetras
    {
        public string NumeroEnLetras = null;
        /// <summary>
        /// Funcion que utiliza para converti un numero en letras
        /// </summary>
        /// <param name="dMonto">Cantidad a Convertir en Letras</param>
        /// 

        public ConversorNumALetras(decimal dMonto)
        {
            if (dMonto == 0)
            {
                NumeroEnLetras = "CERO LEMPIRAS";
            }
            else
            {
                bool Valor_Negativo = false;

                if (dMonto < 0)
                {
                    Valor_Negativo = true;
                    dMonto *= -1;
                }


                decimal decimales = 0;
                decimales = dMonto - Decimal.Truncate(dMonto);
                if (decimales < 0)
                {
                    decimales *= -100;
                }
                else
                {
                    decimales *= 100;
                }
                NumeroEnLetras = (Num2Text(Convert.ToInt64(Decimal.Truncate(Convert.ToDecimal(dMonto))))) + " LEMPIRAS con " + Convert.ToInt32(decimales) + "/100 CTVS.";

                if (Valor_Negativo)
                {
                    NumeroEnLetras = "( Negativo ) " + NumeroEnLetras;
                }
            }
            //
            // TODO: Add constructor logic here
            //
        }

        private string Num2Text(long Dvalue)
        {
            switch (Convert.ToInt32(Dvalue))
            {
                case 0:
                    return "CERO";
                case 1:
                    return "UN";
                case 2:
                    return "DOS";
                case 3:
                    return "TRES";
                case 4:
                    return "CUATRO";
                case 5:
                    return "CINCO";
                case 6:
                    return "SEIS";
                case 7:
                    return "SIETE";
                case 8:
                    return "OCHO";
                case 9:
                    return "NUEVE";
                case 10:
                    return "DIEZ";
                case 11:
                    return "ONCE";
                case 12:
                    return "DOCE";
                case 13:
                    return "TRECE";
                case 14:
                    return "CATORCE";
                case 15:
                    return "QUINCE";
                case 16:
                case 17:
                case 18:
                case 19:
                    return "DIECI" + Num2Text(Dvalue - 10);
                case 20:
                    return "VEINTE";
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                    return "VEINTI" + Num2Text(Dvalue - 20);
                case 30:
                    return "TREINTA";
                case 40:
                    return "CUARENTA";
                case 50:
                    return "CINCUENTA";
                case 60:
                    return "SESENTA";
                case 70:
                    return "SETENTA";
                case 80:
                    return "OCHENTA";
                case 90:
                    return "NOVENTA";
                #region case <= 99
                case 91:
                case 92:
                case 93:
                case 94:
                case 95:
                case 96:
                case 97:
                case 98:
                case 99:
                    #endregion
                    return Num2Text(Convert.ToInt32(Dvalue / 10) * 10) + " Y " + Num2Text(Dvalue % 10);
                case 100:
                    return "CIEN";
                #region case <= 199
                case 101:
                case 102:
                case 103:
                case 104:
                case 105:
                case 106:
                case 107:
                case 108:
                case 109:
                case 110:
                case 111:
                case 112:
                case 113:
                case 114:
                case 115:
                case 116:
                case 117:
                case 118:
                case 119:
                case 120:
                case 121:
                case 122:
                case 123:
                case 124:
                case 125:
                case 126:
                case 127:
                case 128:
                case 129:
                case 130:
                case 131:
                case 132:
                case 133:
                case 134:
                case 135:
                case 136:
                case 137:
                case 138:
                case 139:
                case 140:
                case 141:
                case 142:
                case 143:
                case 144:
                case 145:
                case 146:
                case 147:
                case 148:
                case 149:
                case 150:
                case 151:
                case 152:
                case 153:
                case 154:
                case 155:
                case 156:
                case 157:
                case 158:
                case 159:
                case 160:
                case 161:
                case 162:
                case 163:
                case 164:
                case 165:
                case 166:
                case 167:
                case 168:
                case 169:
                case 170:
                case 171:
                case 172:
                case 173:
                case 174:
                case 175:
                case 176:
                case 177:
                case 178:
                case 179:
                case 180:
                case 181:
                case 182:
                case 183:
                case 184:
                case 185:
                case 186:
                case 187:
                case 188:
                case 189:
                case 190:
                case 191:
                case 192:
                case 193:
                case 194:
                case 195:
                case 196:
                case 197:
                case 198:
                case 199:
                    #endregion
                    return "CIENTO " + Num2Text(Dvalue - 100);
                case 200:
                case 300:
                case 400:
                case 600:
                case 800:
                    return Num2Text(Convert.ToInt32(Dvalue / 100)) + "CIENTOS";
                case 500:
                    return "QUINIENTOS";
                case 700:
                    return "SETECIENTOS";
                case 900:
                    return "NOVECIENTOS";
                #region case <=999
                case 901:
                case 902:
                case 903:
                case 904:
                case 905:
                case 906:
                case 907:
                case 908:
                case 909:
                case 910:
                case 911:
                case 912:
                case 913:
                case 914:
                case 915:
                case 916:
                case 917:
                case 918:
                case 919:
                case 920:
                case 921:
                case 922:
                case 923:
                case 924:
                case 925:
                case 926:
                case 927:
                case 928:
                case 929:
                case 930:
                case 931:
                case 932:
                case 933:
                case 934:
                case 935:
                case 936:
                case 937:
                case 938:
                case 939:
                case 940:
                case 941:
                case 942:
                case 943:
                case 944:
                case 945:
                case 946:
                case 947:
                case 948:
                case 949:
                case 950:
                case 951:
                case 952:
                case 953:
                case 954:
                case 955:
                case 956:
                case 957:
                case 958:
                case 959:
                case 960:
                case 961:
                case 962:
                case 963:
                case 964:
                case 965:
                case 966:
                case 967:
                case 968:
                case 969:
                case 970:
                case 971:
                case 972:
                case 973:
                case 974:
                case 975:
                case 976:
                case 977:
                case 978:
                case 979:
                case 980:
                case 981:
                case 982:
                case 983:
                case 984:
                case 985:
                case 986:
                case 987:
                case 988:
                case 989:
                case 990:
                case 991:
                case 992:
                case 993:
                case 994:
                case 995:
                case 996:
                case 997:
                case 998:
                case 999:
                    #endregion
                    return Num2Text(Convert.ToInt32(Dvalue / 100) * 100) + " " + Num2Text(Dvalue % 100);
                case 1000:
                    return "MIL";

                default:
                    if (Dvalue > 30 && Dvalue < 40)
                    {
                        return "TREINTA Y " + Num2Text(Dvalue - 30);
                    }

                    if (Dvalue > 40 && Dvalue < 50)
                    {
                        return "CUARENTA Y " + Num2Text(Dvalue - 40);
                    }

                    if (Dvalue > 50 && Dvalue < 60)
                    {
                        return "CINCUENTA Y " + Num2Text(Dvalue - 50);
                    }

                    if (Dvalue > 60 && Dvalue < 70)
                    {
                        return "SESENTA Y " + Num2Text(Dvalue - 60);
                    }

                    if (Dvalue > 70 && Dvalue < 80)
                    {
                        return "SETENTA Y " + Num2Text(Dvalue - 70);
                    }

                    if (Dvalue > 80 && Dvalue < 90)
                    {
                        return "OCHENTA Y " + Num2Text(Dvalue - 80);
                    }


                    if (Dvalue > 200 && Dvalue < 300)
                    {
                        return "DOSCIENTOS " + Num2Text(Dvalue - 200);
                    }

                    if (Dvalue > 300 && Dvalue < 400)
                    {
                        return "TRESCIENTOS " + Num2Text(Dvalue - 300);
                    }

                    if (Dvalue > 400 && Dvalue < 500)
                    {
                        return "CUATROCIENTOS " + Num2Text(Dvalue - 400);
                    }

                    if (Dvalue > 500 && Dvalue < 600)
                    {
                        return "QUINIENTOS " + Num2Text(Dvalue - 500);
                    }

                    if (Dvalue > 600 && Dvalue < 700)
                    {
                        return "SEISCIENTOS " + Num2Text(Dvalue - 600);
                    }

                    if (Dvalue > 700 && Dvalue < 800)
                    {
                        return "SETECIENTOS " + Num2Text(Dvalue - 700);
                    }

                    if (Dvalue > 800 && Dvalue < 900)
                    {
                        return "OCHOCIENTOS " + Num2Text(Dvalue - 800);
                    }

                    if (Dvalue > 1000 && Dvalue < 2000)
                    {
                        return "MIL " + Num2Text(Dvalue % 1000);
                    }

                    if (Dvalue < 1000000)
                    {
                        string num2text = "";
                        num2text = Num2Text(Convert.ToInt32(Dvalue / 1000)) + " MIL";

                        if ((Dvalue % 1000) != 0)
                        {
                            return num2text + " " + Num2Text(Dvalue % 1000);
                        }
                        else
                        {
                            return num2text;
                        }
                    }

                    if (Dvalue == 1000000)
                    {
                        return "UN MILLON";
                    }

                    if (Dvalue < 2000000)
                    {
                        return "UN MILLON " + Num2Text(Dvalue % 1000000);
                    }

                    if (Dvalue < 1000000000000)
                    {
                        string num2text = "";
                        num2text = Num2Text(Convert.ToInt32(Dvalue / 1000000)) + " MILLONES ";

                        if ((Dvalue - Convert.ToInt32(Dvalue / 1000000) * 1000000) != 0)
                        {
                            return num2text + " " + Num2Text(Dvalue - Convert.ToInt32(Dvalue / 1000000) * 1000000);
                        }
                        else
                        {
                            return num2text;
                        }
                    }
                    if (Dvalue == 1000000000000)
                    {
                        return "UN BILLON";
                    }
                    if (Dvalue < 2000000000000)
                    {
                        return "UN BILLON " + Num2Text(Dvalue - Convert.ToInt32(Dvalue / 1000000000000) * 1000000000000);
                    }
                    else
                    {
                        string num2text = Num2Text(Convert.ToInt32(Dvalue / 1000000000000.0)) + " BILLONES";
                        if ((Dvalue - Convert.ToInt32(Dvalue / 1000000000000) * 1000000000000) != 0)
                        {
                            return num2text + " " + Num2Text(Dvalue - Convert.ToInt32(Dvalue / 1000000000000) * 1000000000000);
                        }
                        else
                        {
                            return num2text;
                        }
                    }
            }
        }

    }
}
