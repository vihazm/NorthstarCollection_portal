--
-- PostgreSQL database dump
--

\restrict QmrDJj0jxzxXC2ucJT6jBuuQ2YWwxOTf9KNMVoTEVyd01v4hGkAQIXzt3TDXAZH

-- Dumped from database version 18.1
-- Dumped by pg_dump version 18.1

-- Started on 2026-02-02 18:02:35

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 224 (class 1259 OID 16415)
-- Name: tbl_fleet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_fleet (
    "CarID" integer NOT NULL,
    "Brand" text NOT NULL,
    "Model" text NOT NULL,
    "DailyRate" numeric(10,2),
    "Status" text DEFAULT 'Available'::text,
    "UniqueToken" text,
    "IsActive" integer DEFAULT 1
);


ALTER TABLE public.tbl_fleet OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16414)
-- Name: tbl_fleet_CarID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."tbl_fleet_CarID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public."tbl_fleet_CarID_seq" OWNER TO postgres;

--
-- TOC entry 5048 (class 0 OID 0)
-- Dependencies: 223
-- Name: tbl_fleet_CarID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."tbl_fleet_CarID_seq" OWNED BY public.tbl_fleet."CarID";


--
-- TOC entry 227 (class 1259 OID 16438)
-- Name: tbl_loginhistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_loginhistory (
    log_id integer NOT NULL,
    username character varying(50),
    "position" character varying(50),
    login_time timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    logout_time timestamp without time zone
);


ALTER TABLE public.tbl_loginhistory OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16437)
-- Name: tbl_loginhistory_log_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_loginhistory_log_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_loginhistory_log_id_seq OWNER TO postgres;

--
-- TOC entry 5049 (class 0 OID 0)
-- Dependencies: 226
-- Name: tbl_loginhistory_log_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_loginhistory_log_id_seq OWNED BY public.tbl_loginhistory.log_id;


--
-- TOC entry 222 (class 1259 OID 16405)
-- Name: tbl_reservations; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_reservations (
    reservationid integer NOT NULL,
    carid integer,
    customername text,
    customerphone text,
    insurancenumber text,
    startdate date,
    enddate date,
    deposit numeric(10,2),
    totalcost numeric(10,2)
);


ALTER TABLE public.tbl_reservations OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16404)
-- Name: tbl_reservations_reservationid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_reservations_reservationid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_reservations_reservationid_seq OWNER TO postgres;

--
-- TOC entry 5050 (class 0 OID 0)
-- Dependencies: 221
-- Name: tbl_reservations_reservationid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_reservations_reservationid_seq OWNED BY public.tbl_reservations.reservationid;


--
-- TOC entry 225 (class 1259 OID 16430)
-- Name: tbl_settings; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_settings (
    setting_name character varying(50) NOT NULL,
    setting_value numeric(18,2) NOT NULL
);


ALTER TABLE public.tbl_settings OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16390)
-- Name: tbl_users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tbl_users (
    userid integer NOT NULL,
    username text NOT NULL,
    password text NOT NULL,
    "UserRole" text NOT NULL
);


ALTER TABLE public.tbl_users OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16389)
-- Name: tbl_users_userid_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tbl_users_userid_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tbl_users_userid_seq OWNER TO postgres;

--
-- TOC entry 5051 (class 0 OID 0)
-- Dependencies: 219
-- Name: tbl_users_userid_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tbl_users_userid_seq OWNED BY public.tbl_users.userid;


--
-- TOC entry 4877 (class 2604 OID 16418)
-- Name: tbl_fleet CarID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_fleet ALTER COLUMN "CarID" SET DEFAULT nextval('public."tbl_fleet_CarID_seq"'::regclass);


--
-- TOC entry 4880 (class 2604 OID 16441)
-- Name: tbl_loginhistory log_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_loginhistory ALTER COLUMN log_id SET DEFAULT nextval('public.tbl_loginhistory_log_id_seq'::regclass);


--
-- TOC entry 4876 (class 2604 OID 16408)
-- Name: tbl_reservations reservationid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_reservations ALTER COLUMN reservationid SET DEFAULT nextval('public.tbl_reservations_reservationid_seq'::regclass);


--
-- TOC entry 4875 (class 2604 OID 16393)
-- Name: tbl_users userid; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_users ALTER COLUMN userid SET DEFAULT nextval('public.tbl_users_userid_seq'::regclass);


--
-- TOC entry 4889 (class 2606 OID 16429)
-- Name: tbl_fleet tbl_fleet_UniqueToken_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_fleet
    ADD CONSTRAINT "tbl_fleet_UniqueToken_key" UNIQUE ("UniqueToken");


--
-- TOC entry 4891 (class 2606 OID 16427)
-- Name: tbl_fleet tbl_fleet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_fleet
    ADD CONSTRAINT tbl_fleet_pkey PRIMARY KEY ("CarID");


--
-- TOC entry 4895 (class 2606 OID 16445)
-- Name: tbl_loginhistory tbl_loginhistory_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_loginhistory
    ADD CONSTRAINT tbl_loginhistory_pkey PRIMARY KEY (log_id);


--
-- TOC entry 4887 (class 2606 OID 16413)
-- Name: tbl_reservations tbl_reservations_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_reservations
    ADD CONSTRAINT tbl_reservations_pkey PRIMARY KEY (reservationid);


--
-- TOC entry 4893 (class 2606 OID 16436)
-- Name: tbl_settings tbl_settings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_settings
    ADD CONSTRAINT tbl_settings_pkey PRIMARY KEY (setting_name);


--
-- TOC entry 4883 (class 2606 OID 16401)
-- Name: tbl_users tbl_users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_users
    ADD CONSTRAINT tbl_users_pkey PRIMARY KEY (userid);


--
-- TOC entry 4885 (class 2606 OID 16403)
-- Name: tbl_users tbl_users_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tbl_users
    ADD CONSTRAINT tbl_users_username_key UNIQUE (username);


-- Completed on 2026-02-02 18:02:35

--
-- PostgreSQL database dump complete
--

\unrestrict QmrDJj0jxzxXC2ucJT6jBuuQ2YWwxOTf9KNMVoTEVyd01v4hGkAQIXzt3TDXAZH

