PGDMP  
                     |            ControleFinanceiro    16.3    16.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
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
    public          postgres    false    217   �       �           0    0    Contas_Id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Contas_Id_seq"', 26, true);
          public          postgres    false    216            V           2606    16539    Contas PK_public.Contas 
   CONSTRAINT     [   ALTER TABLE ONLY public."Contas"
    ADD CONSTRAINT "PK_public.Contas" PRIMARY KEY ("Id");
 E   ALTER TABLE ONLY public."Contas" DROP CONSTRAINT "PK_public.Contas";
       public            postgres    false    215            X           2606    16541 /   __MigrationHistory PK_public.__MigrationHistory 
   CONSTRAINT     �   ALTER TABLE ONLY public."__MigrationHistory"
    ADD CONSTRAINT "PK_public.__MigrationHistory" PRIMARY KEY ("MigrationId", "ContextKey");
 ]   ALTER TABLE ONLY public."__MigrationHistory" DROP CONSTRAINT "PK_public.__MigrationHistory";
       public            postgres    false    217    217            �   G  x���1n1Ek�,��g8���F
�a���#��"�d�%�9�� ]Z],C��xW@� 4o���$��e^�֗��(�l�Sh��l���m6k����l{�9u�>/����s�)���aH4·��@P��Vӕ �����Y�G'��������R�����Y��
 N��P\yocuVI*]yX�:��#!d��U�W7��<�� Z��| �LJ$�.��)�'���� ���d�a�����\�A|��.���!Pc�@
�I���������X&����u�'}���>ӳv\��6/��B���p�W�I�#��D�a^��X>���i�Z�.�ʌ5�f��#�n<����g)ո��'}�dQy������_F�׵�TY�m�5�%8����2�I�g��=�4�w�{��gV��Q헳*��]`~�xw��Q�m\4!��R�mMm0qGǻ����X!�9s�C��[T��/����mD��}��k�}�a������8��(���<$h�xI���A���C��ז��-���z!T�{�;��F���Zt�֌���1�}E�{3�� :O]�      �     x�E���%�D�33��RJ�|��À���m���;�7nh��[�%�"�./�u�xɲ_�����?���G��_��?��Ǐ��Ǘ�����\�����ꩿ<�{Z�x޲�5~k�m����a>Y&�V��Q�}���4�$�e�6�4r繮6M��K����q�*׽�x�L��)*S�(�KΙB�سh��X̄�_]un�==������bJ��6�ݨ�h<X'8v��T}��n��ʧ��u��c�w�K�t}�f����j�����.KtP���(]��������t���tG7�G?�������1.B�%)Zo�9+�Q��v�VhJo������d���T�f�䱖ǂ�fL���ۮ�&y��]J�Y�x8�-FGL�^����Yʕ��QK���١���(*�!��n�ߍ��{�1{�0���ۗr��&��c���5^[���ܵ.��z�,�i�.�W%�43�4ὥx"(�s2��I�0��|ݴ�
X1�ԤbA�+�0B����K�{ՅG]��'%!��DRZ-�6��š5��>�R�F��"�
��fL����{�4ҒQ��&eMT3�3*����[��^�Zb����-
�q�|�r^�%�
���b�FLW��0چ�Nkw��z�z��b��;"�p�~��"'G���yo=Q��w�Z1ç��>�L��/��<�{�`ZgG�2����"�����_s�aV���l�A)K�΁a�V�PL�0!.��B�`�HTK)�� &O���/k,�@��~�0�W4o3����>��l�T��(�|s ��0 0�B�wQ�߬�n�y�Ρ�9����~~a�+�AC�C�Ŏ���H����N���`�كp������!�W�3�+�)AW�s�O:CG�Hx3�����~�Mzmbs�� L��؈V�ź� #F��,� �тb�D�@P<sKkpJ�&�}P���	��: ���]PX3�U<B5Շ$�l�eK]���6o�pm`9�����Zg'�m��vBaO�-wh ���	�gÍ+	-b�Xc?�3E��@��u1�|�?p��C��x�^�]�N
�@�V=�6J
ϑ�w>�.����%���K��p(�=@�Wp�����m V��+,ջ�a�[`��FBҀ�.�R��8�h�҆�?Y(B�ؠ �-����9���~�D�Sv�p��`�
��P>cq~ג������@`���P�Ǻ&8����zG�0O@i���w���0���-�R|���/_�7�&_�����?��dy     