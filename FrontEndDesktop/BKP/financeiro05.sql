PGDMP      2        	    	    |            ControleFinanceiro    16.3    16.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16525    ControleFinanceiro    DATABASE     �   CREATE DATABASE "ControleFinanceiro" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
 $   DROP DATABASE "ControleFinanceiro";
                postgres    false            �            1259    16526    Contas    TABLE     �   CREATE TABLE public."Contas" (
    "Id" integer NOT NULL,
    "Nome" text,
    "Valor" numeric(18,2) NOT NULL,
    "DataVencimento" timestamp without time zone NOT NULL,
    "DataPagamento" timestamp without time zone,
    "Pago" boolean NOT NULL
);
    DROP TABLE public."Contas";
       public         heap    postgres    false            �            1259    16531    Contas_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."Contas_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public."Contas_Id_seq";
       public          postgres    false    215            �           0    0    Contas_Id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public."Contas_Id_seq" OWNED BY public."Contas"."Id";
          public          postgres    false    216            �            1259    16532    __MigrationHistory    TABLE     �   CREATE TABLE public."__MigrationHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ContextKey" character varying(300) NOT NULL,
    "Model" bytea NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 (   DROP TABLE public."__MigrationHistory";
       public         heap    postgres    false            T           2604    16537 	   Contas Id    DEFAULT     l   ALTER TABLE ONLY public."Contas" ALTER COLUMN "Id" SET DEFAULT nextval('public."Contas_Id_seq"'::regclass);
 <   ALTER TABLE public."Contas" ALTER COLUMN "Id" DROP DEFAULT;
       public          postgres    false    216    215            �          0    16526    Contas 
   TABLE DATA           d   COPY public."Contas" ("Id", "Nome", "Valor", "DataVencimento", "DataPagamento", "Pago") FROM stdin;
    public          postgres    false    215   �       �          0    16532    __MigrationHistory 
   TABLE DATA           f   COPY public."__MigrationHistory" ("MigrationId", "ContextKey", "Model", "ProductVersion") FROM stdin;
    public          postgres    false    217          �           0    0    Contas_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Contas_Id_seq"', 109, true);
          public          postgres    false    216            V           2606    16539    Contas PK_public.Contas 
   CONSTRAINT     [   ALTER TABLE ONLY public."Contas"
    ADD CONSTRAINT "PK_public.Contas" PRIMARY KEY ("Id");
 E   ALTER TABLE ONLY public."Contas" DROP CONSTRAINT "PK_public.Contas";
       public            postgres    false    215            X           2606    16541 /   __MigrationHistory PK_public.__MigrationHistory 
   CONSTRAINT     �   ALTER TABLE ONLY public."__MigrationHistory"
    ADD CONSTRAINT "PK_public.__MigrationHistory" PRIMARY KEY ("MigrationId", "ContextKey");
 ]   ALTER TABLE ONLY public."__MigrationHistory" DROP CONSTRAINT "PK_public.__MigrationHistory";
       public            postgres    false    217    217            �   b  x��VMo7=ӿb���g8$�{s�ԁ�#�\6���J�"��)r��W���hWҒ� �B��͛7�n7���M��)2A;�� ]/�1m�� ���@�`bpjsa���˪�{��K�P��^�i��yo����^l�����G SE�?�)P`+^�.7�z�o�ʷ��fѭWo@�!����s�SV`����?��k��@g����'��m�v�?�����' �f�HO��z����T$�{i� 5�!�)P��׍��Sh�&b�k8@�!�SV���׮��M�����_�y��jf���ן��f1엏���~�Y)�P���JԑC������IR���O��~���H��4&�%��n!�u�CJ>����ss���	��n���)��
�x��jh��`[r"�c�⍧���e:ړ9#�o�i,{>���$�[K�_� A�I�1b�{;gZ�:0�M.Elj��=��A�:�����h�P��"�7봃@�I@��*z��E�Z��QB���(��1���6&4gL����%Ј�m*Rņ�hÊf�B���1)_t�~F->�Ţ��%[�tx�,���R����%����������	f�����IE��d)f}�E`����"�s�r0�B@H`1�:���y#���� XI�EY�_��i�Dw�/B�ql�ŵhtD��]U�:.،s�����d�pºYO�8ג�-�!��Y�`�/��Sf��s�����%j��Ry�pa��"�29Y�3Bu��i�db-�$d}�?�׻ǄZ���Fr�C�y#W�Ԛ!��H�䓩���B��ȄQ��O<���N�����"�Pb&2��d�&�P���+�;%�3İ�:+I�<^�)�bs���<��*�TUY�ऴ�1r�|o���b�h�l��q^���/7�9�2�B6]���Cr<W͚�:���ktfJ~?�n-)�;o��r\�L�4H�(o=.n��� #�k��sҊvחxY�;�}�O�t�cV��_o{|��`8d��*?�S��P�k*�1��J������ �t'�I�ݥ��5c!��H��2�����ͦsM:������h�ܧ�]�0�Yd��"ϗ�H�������*�      �     x�E���%�D�33��RJ�|��À���m���;�7nh��[�%�"�./�u�xɲ_�����?���G��_��?��Ǐ��Ǘ�����\�����ꩿ<�{Z�x޲�5~k�m����a>Y&�V��Q�}���4�$�e�6�4r繮6M��K����q�*׽�x�L��)*S�(�KΙB�سh��X̄�_]un�==������bJ��6�ݨ�h<X'8v��T}��n��ʧ��u��c�w�K�t}�f����j�����.KtP���(]��������t���tG7�G?�������1.B�%)Zo�9+�Q��v�VhJo������d���T�f�䱖ǂ�fL���ۮ�&y��]J�Y�x8�-FGL�^����Yʕ��QK���١���(*�!��n�ߍ��{�1{�0���ۗr��&��c���5^[���ܵ.��z�,�i�.�W%�43�4ὥx"(�s2��I�0��|ݴ�
X1�ԤbA�+�0B����K�{ՅG]��'%!��DRZ-�6��š5��>�R�F��"�
��fL����{�4ҒQ��&eMT3�3*����[��^�Zb����-
�q�|�r^�%�
���b�FLW��0چ�Nkw��z�z��b��;"�p�~��"'G���yo=Q��w�Z1ç��>�L��/��<�{�`ZgG�2����"�����_s�aV���l�A)K�΁a�V�PL�0!.��B�`�HTK)�� &O���/k,�@��~�0�W4o3����>��l�T��(�|s ��0 0�B�wQ�߬�n�y�Ρ�9����~~a�+�AC�C�Ŏ���H����N���`�كp������!�W�3�+�)AW�s�O:CG�Hx3�����~�Mzmbs�� L��؈V�ź� #F��,� �тb�D�@P<sKkpJ�&�}P���	��: ���]PX3�U<B5Շ$�l�eK]���6o�pm`9�����Zg'�m��vBaO�-wh ���	�gÍ+	-b�Xc?�3E��@��u1�|�?p��C��x�^�]�N
�@�V=�6J
ϑ�w>�.����%���K��p(�=@�Wp�����m V��+,ջ�a�[`��FBҀ�.�R��8�h�҆�?Y(B�ؠ �-����9���~�D�Sv�p��`�
��P>cq~ג������@`���P�Ǻ&8����zG�0O@i���w���0���-�R|���/_�7�&_�����?��dy     