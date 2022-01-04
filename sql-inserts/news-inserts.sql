
-- Countries
insert into Countries (Name) values ('USA');
insert into Countries (Name) values ('United Kingdom');
insert into Countries (Name) values ('France');
insert into Countries (Name) values ('Germany');

-- News Agencies
insert into NewsAgencies(Name,Address,Email,Tel,Description,CountryID) values ('Reuters','Reuters Building, City of London, London, England','reuters@reuters.com','+44 123456789','With unmatched coverage in over 16 languages, and reaching billions of people worldwide every day, we provide trusted intelligence that powers humans and machines to make smart decisions. Founded in 1851, Reuters has remained true to the Trust Principles of independence, integrity and freedom from bias, working relentlessly to bring news from the source and from every corner of the world.',2);
insert into NewsAgencies(Name,Address,Email,Tel,Description,CountryID) values('Associated Press','200 Liberty Street, New York City, New York','associated_press@ap.org','+1 987654321','The Associated Press (AP) is an American non-profit news agency headquartered in New York City. Founded in 1846, it operates as a cooperative, unincorporated association. Its members are U.S. newspapers and broadcasters. News reports that it distributes to its members and customers are produced in English, Spanish, and Arabic.',1);
insert into NewsAgencies(Name,Address,Email,Tel,Description,CountryID) values('United Press International','	1200 N. Federal Highway, Suite 200 Boca Raton, Florida 33432','united-press@upi.com','+1 345612789','United Press International (UPI) is an international news agency whose newswires, photo, news film, and audio services provided news material to thousands of newspapers, magazines, radio and television stations for most of the 20th century.',1)
insert into NewsAgencies(Name,Address,Email,Tel,Description,CountryID) values('Agence France-Presse','13, Place de la Bourse, 75002, Paris','agence@afp.fr','+331 4041 4646','Agence France-Presse (AFP) is an international news agency headquartered in Paris, France. Founded in 1835 as Havas, it is the worlds oldest news agency.AFP has regional headquarters in Nicosia, Montevideo, Hong Kong and Washington, D.C., and news bureaus in 151 countries in 201 locations.',3);
insert into NewsAgencies(Name,Address,Email,Tel,Description,CountryID) values('Deutsche Presse-Agentur GmbH','Mittelweg 38, 20148, Hamburg','dpa@dpa.de','+49 123456987','The German Press Agency (dpa) was founded in 1949 and is one of the worlds leading independent news agencies. dpa supplies media outlets, businesses and other organizations with editorial content, including text, photos, videos, graphics, audio and other formats.',4);

-- update NewsAgencies set Name = 'United Press International' where ID =3;

-- Article Topics
insert into ArticleTopics (Name) values ('World');
insert into ArticleTopics (Name) values ('Business');
insert into ArticleTopics (Name) values ('Markets');
insert into ArticleTopics (Name) values ('Politics');
insert into ArticleTopics (Name) values ('Technology');
insert into ArticleTopics (Name) values ('Art');
insert into ArticleTopics (Name) values ('Sports');

-- Photo Types
insert into PhotoTypes (Name) values ('Portrait');
insert into PhotoTypes (Name) values ('Landscape');
insert into PhotoTypes (Name) values ('Cityscape');
insert into PhotoTypes (Name) values ('People');
insert into PhotoTypes (Name) values ('Nature');
insert into PhotoTypes (Name) values ('Sports');

-- Authors
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values ('Thomas','Reuter','reuter@reuters.com','+44 and no more','1909-11-18', 'The Big Guy at Reuters', 1);
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values ('Jimmy','Reuter','jr@reuters.com','+44 and a bit more','1958-07-10','The little guy at Reuters',1);
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('Clark','Kent','superguy@ap.org','+1 never fear','1955-01-01','The most super guy and journalist in the Solar System',2)
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('John','Noble','john@upi.com','+1 know the score', '2021-09-15','The best reporter that should be',3)
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('Adam','Smith','adam@upi.com','+1 always and forever', '1976-09-15','A must read for the future',3)
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('Someguy','Havas','hava@afp.fr','+331 he is dead', '1900-01-02','Created AFP and death set him free',4);
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('Hans','Schriebwaffen','hss@dpa.de','+44 ein zu zwei zu drei','1989-11-08','A bright hope in the journo world',5);
insert into Authors (FirstName,LastName,Email,Tel,RegisteredOn,Bio,NewsAgencyID) values('Anna','Becker','anna.b@dpa.de','+44 freuline schon sein','1989-11-08','A journalist with class',5);

-- Articles
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'Amazon and Apple handed $225 million in Italian antitrust',
null,
'2021-11-23',
'Italy''s antitrust authority has fined U.S. tech giants Amazon.com (AMZN.O) and Apple Inc (AAPL.O)',
'MILAN, Nov 23 (Reuters) - Italy''s antitrust authority has fined U.S. tech giants Amazon.com (AMZN.O) and Apple Inc (AAPL.O) a total of more than 200 million euros ($225 million) for alleged anti-competitive cooperation in the sale of Apple and Beats products. Contractual provisions of a 2018 agreement between the companies meant only selected resellers were allowed to sell Apple and Beats products on Amazon.it, the watchdog said, adding that this was in violation of European Union rules and affected competition on prices. Both Apple and Amazon said they plan to appeal against the fines.The authority imposed a fine of 68.7 million euros on Amazon and 134.5 million euros on Apple, ordering the companies to end the restrictions to give retailers of genuine Apple and Beats products access to Amazon.it in a non-discriminatory manner.',
4,2);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'U.S. challenges OPEC+ with coordinated release of oil',
'OPEC+ has rebuffed repeated U.S. calls for more crude',
'2021-11-23',
'The United States said on Tuesday it will release millions of barrels of oil from strategic reserves in coordination with China, India, South Korea, Japan and Britain, to try to cool prices after OPEC+ producers repeatedly ignored calls for more crude.',
'WASHINGTON, Nov 23 (Reuters) - The United States said on Tuesday it will release millions of barrels of oil from strategic reserves in coordination with China, India, South Korea, Japan and Britain, to try to cool prices after OPEC+ producers repeatedly ignored calls for more crude. U.S. President Joe Biden, facing low approval ratings amid rising inflation ahead of next year''s congressional elections, has grown frustrated at repeatedly asking the Organization of the Petroleum Exporting Countries and its allies, known as OPEC+, to pump more oil without getting any response. Crude oil prices recently touched seven-year highs and although they are still some way short of levels reached between 2011 and 2014, when they broke through $100 a barrel, many consumers are feeling the pain of a dramatic increase from a year ago. The U.S. announcement was for a release of 50 million barrels, the equivalent of about two and a half days of U.S. demand. India, meanwhile, said it would release 5 million barrels, while Britain said it would allow the voluntary release of 1.5 million barrels of oil from privately held reserves.',
4,3);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'Fed must ensure inflation does not become ''endemic''',
null,
'2021-11-22',
'The U.S. Federal Reserve during Jerome Powell''s second term as chair will have an important role to play over the longer term to ensure that inflation does not become "endemic," Treasury Secretary Janet Yellen told CNBC on Monday.',
'WASHINGTON, Nov 22 (Reuters) - The U.S. Federal Reserve during Jerome Powell''s second term as chair will have an important role to play over the longer term to ensure that inflation does not become "endemic," Treasury Secretary Janet Yellen told CNBC on Monday. Yellen said she believed Powell''s nomination and that of Lael Brainard as vice chair would win broad support in Congress and that she was confident in their ability "to make good judgments" on balancing the Fed''s dual mandates of maintaining maximum employment and price stability. "I think we do have to be concerned about inflation. It''s reached the levels that concern most Americans who are seeing it and their pocketbook when they go to the store to buy food or to fill up their cars," said Yellen, who chaired the Fed from 2014 to 2018.',
6,2);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'Nasdaq, S&P 500 end down after hitting record highs',
null,
'2021-11-23',
'Indexes: Dow up 0.86%, S&P up 0.66%, Nasdaq down 0.16%',
'Nov 22 (Reuters) - The S&P 500 ended lower and the Nasdaq tumbled deep into negative territory on Monday after both earlier hit record highs following the announcement of a second term for Federal Reserve Chair Jerome Powell.',
6,3);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'U.S. tech execs hone approach to counter unions',
null,
'2021-11-23',
'Signs are stacked for Amazon workers before they arrive',
'SAN FRANCISCO, Nov 23 (Reuters) - In June, managers at location data startup Mapbox came to employees with alarming news: The company had lost a $150 million investment, and worker organizing was to blame.',
5,5);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'Xiaomi revenue misses estimates, competition intensifies',
'Competition is competition',
'2021-11-23',
'SHANGHAI, Nov 23 (Reuters) - China''s Xiaomi Corp (1810.HK) on Tuesday reported a smaller-than-expected 8.2% rise in third-quarter revenue as smartphone sales growth stalled amid intensifying competition from rivals.',
'SHANGHAI, Nov 23 (Reuters) - China''s Xiaomi Corp (1810.HK) on Tuesday reported a smaller-than-expected 8.2% rise in third-quarter revenue as smartphone sales growth stalled amid intensifying competition from rivals.',
5,5);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values ('
Pioli wants Milan to convert performances into results',
null,
'2021-11-23',
'Soccer Football - Serie A - Fiorentina v AC Milan - Stadio Artemio Franchi',
'MILAN, Italy, Nov 23 (Reuters) - AC Milan coach Stefano Pioli has called on his side to turn their impressive Champions League performances into results as the seven-time European Cup winners head into Wednesday''s trip to Atletico Madrid needing to win at all costs.',
8,7);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'Southgate wants to ''prove people wrong'' at club level after',
null,
'2021-11-23',
'Soccer Football - World Cup - UEFA Qualifiers',
'Nov 23 (Reuters) - England manager Gareth Southgate said he would like to return to club management at some point and that he would be motivated to "prove people wrong" about his track record in domestic football.',
8,7);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'New Zealand ponder ''enormity'' of India challenge',
'Sports balls is enormous',
'2021-11-21',
'Cricket - ICC World Test Championship Final - India v New Zealand',
'Nov 23 (Reuters) - New Zealand open their World Test Championship defence against India this week with an air of fatigue after a long road trip and the emotional letdown of the T20 World Cup.',
8,7);
insert into Articles (Title,SubTitle,PublicationDate,Abstract,Content,AuthorID,ArticleTopicID) values (
'New York Times urges no ''restraint'' against Project Veritas',
null,
'2021-11-23',
'The New York Times building is seen in Manhattan',
'NEW YORK, Nov 22 (Reuters) - The New York Times urged a judge to restore what it called its constitutionally-protected freedom to cover the conservative activist group Project Veritas, on the eve of a hearing on a rare attempt to block news coverage by major media.',
9,4);
-- Photos
--insert into Photos (Title,Location,TakenOn,PublicationDate,Description,Data,AuthorID,PhotoTypeID) values ('Putin','Moscow','2021-11-20','2021-11-23','It''s Putin too', cast((SELECT * FROM OPENROWSET(BULK 'C:\Users\kalin\source\repos\News\photos\putin.jpg', SINGLE_CLOB) as Data)as varbinary(max)),8,1);
--insert into Photos (Title,Location,TakenOn,PublicationDate,Description,Data,AuthorID,PhotoTypeID) values ('Dogecoin','Clownworld','2021-11-20','2021-11-23','Dogecoin so doge', cast((SELECT * FROM OPENROWSET(BULK 'C:\Users\kalin\source\repos\News\photos\dogecoin.jpg', SINGLE_CLOB) as image)as varbinary(max)),8,1);

insert into Photos (Title,Location,TakenOn,PublicationDate,Description,Data,AuthorID,PhotoTypeID) values ('DogecoinTest2','Clownworld','2021-11-20','2021-11-23','Dogecoin so doge', (SELECT * FROM OPENROWSET(BULK 'C:\Users\kalin\source\repos\News\photos\dogecoin.jpg', SINGLE_BLOB) as image),8,1);
insert into Photos (Title,Location,TakenOn,PublicationDate,Description,Data,AuthorID,PhotoTypeID) values ('Putin','Moscow','2021-11-20','2021-11-23','It''s Putin too', (SELECT * FROM OPENROWSET(BULK 'C:\Users\kalin\source\repos\News\photos\putin.jpg', SINGLE_BLOB) as image),8,1);
insert into Photos (Title,Location,TakenOn,PublicationDate,Description,Data,AuthorID,PhotoTypeID) values ('Dogecoin','Clownworld','2021-11-20','2021-11-23','Dogecoin so doge', (SELECT * FROM OPENROWSET(BULK 'C:\Users\kalin\source\repos\News\photos\dogecoin.jpg', SINGLE_BLOB) as Data),8,1);

delete from Photos where ID=12;