BULK INSERT Indice
FROM '../INPC.csv'
WITH (DATA_SOURCE = 'inpc2',
FIRSTROW
= 2,
         FIELDTERMINATOR =',',  
         ROWTERMINATOR ='\n' 
         );