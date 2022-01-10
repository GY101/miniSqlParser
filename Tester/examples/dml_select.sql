#begin
-- common conustructions tests
-- -- Literals
-- -- -- String literal
SELECT 'hello world';
select N'testing conflict on N - spec symbol and N - as identifier' as n;
select n'abc' as tstConstrN;
#end
#begin
-- -- -- String literal spec symbols
-- bug: two symbols ' afer each other: ''
select * from `select` where `varchar` = 'abc \' ' and `varchar2` = '\'bca';
select COUNT(*) Count from `select` where `varchar` = 'abc \' ' and `varchar2` = '\'bca';
#end
#begin
-- -- -- Number literal
SELECT 1; 
#end 
#begin
-- -- Variables
SELECT @myvar;
select * from t1 limit @varcount;
select * from t1 limit @varoffset, @varcount;
select * from t1 limit @varcount offset @varoffset;
#end

#begin
-- select_column tests
select * from `select`;
select *, `select`.*, `select`.* from `select`;
select *, 'abc' from `select`; 
#end

#begin
-- UNION tests
select 1 union select 2 limit 0,5;
select * from (select 1 union select 2 union select 0) as t order by 1 limit 0,10;
select col1 from t1 union select * from (select 1 as col2) as newt;
select col1 from t1 union (select * from (select 1 as col2) as newt);
select 1 as c1 union (((select 2)));
#end
#begin
-- -- -- subquery in UNION
select 1 union select * from (select 2 union select 3) as table1;
select 1 union (select * from (select 2 union select 3) as table1);
#end
#begin
-- subquery FROM
select * from (((((((select col1 from t1) as ttt))))));
select ship_power.gun_power, ship_info.*
FROM
	(
		select s.name as ship_name, sum(g.power) as gun_power, max(callibr) as max_callibr
		from
			ships s inner join ships_guns sg on s.id = sg.ship_id inner join guns g on g.id = sg.guns_id
		group by s.name
	) ship_power
	inner join
	(
		select s.name as ship_name, sc.class_name, sc.tonange, sc.max_length, sc.start_build, sc.max_guns_size
		from
			ships s inner join ship_class sc on s.class_id = sc.id
	) ship_info using (ship_name)
order by ship_power.ship_name;
#end
#begin
-- JOIN
-- -- -- join condition
select * from t1 inner join (t1 as tt1, t2 as tt2) on t1.col1 = tt1.col1;
select * from  (t1 as tt1, t2 as tt2) inner join t1 on t1.col1 = tt1.col1; 
#end
#begin
-- where_condition test
select col1 from t1 inner join t2 on (t1.col1 = t2.col2);
select table_name from information_schema.TABLES where table_schema = DATABASE();
#end 
#begin
-- not latin1 literals 
select  t.*, tt.* FROM wptests_terms AS t  INNER JOIN wptests_term_taxonomy AS tt ON t.term_id = tt.term_id WHERE tt.taxonomy IN ('category') AND t.name IN ('远征手记') ORDER BY t.name ASC;
#end
#begin
-- JSON functions
SELECT JSON_ARRAY(1, "abc", NULL, TRUE, CURTIME());
SELECT JSON_OBJECT('id', 87, 'name', 'carrot');
SELECT JSON_QUOTE('null'), JSON_QUOTE('"null"');
SELECT JSON_CONTAINS(@j, @j2, '$.a');
SELECT JSON_CONTAINS_PATH(@j, 'one', '$.a', '$.e');
SELECT JSON_EXTRACT('[10, 20, [30, 40]]', '$[1]');
SELECT JSON_KEYS('{"a": 1, "b": {"c": 30}}');
SELECT JSON_OVERLAPS("[1,3,5,7]", "[2,5,7]");
SELECT JSON_SEARCH(@j, 'one', 'abc');
SELECT JSON_ARRAY_APPEND(@j, '$[1]', 1);
SELECT JSON_ARRAY_INSERT(@j, '$[1]', 'x');
SELECT JSON_INSERT(@j, '$.a', 10, '$.c', '[true, false]');
SELECT JSON_MERGE('[1, 2]', '[true, false]');
SELECT JSON_MERGE_PATCH('[1, 2]', '[true, false]');
SELECT JSON_MERGE_PRESERVE('[1, 2]', '[true, false]');
SELECT JSON_REMOVE(@j, '$[1]');
SELECT JSON_REPLACE(@j, '$.a', 10, '$.c', '[true, false]');
SELECT JSON_SET(@j, '$.a', 10, '$.c', '[true, false]');
SELECT @j, JSON_UNQUOTE(@j);
SELECT JSON_DEPTH('{}'), JSON_DEPTH('[]'), JSON_DEPTH('true');
SELECT JSON_LENGTH('[1, 2, {"a": 3}]');
SELECT JSON_TYPE(@j);
SELECT JSON_VALID('{"a": 1}');
SELECT JSON_SCHEMA_VALID(@schema, @document);
SELECT JSON_SCHEMA_VALIDATION_REPORT(@schema, @document);
SELECT JSON_PRETTY('123');
SELECT JSON_STORAGE_FREE(jcol), JSON_STORAGE_FREE(jcol) FROM jtable;
SELECT o_id, JSON_ARRAYAGG(attribute) AS attributes FROM t3 GROUP BY o_id;
SELECT o_id, JSON_OBJECTAGG(attribute, value) FROM t3 GROUP BY o_id;
#end
SELECT trigger.num FROM test `trigger`;
-- Valid when SELECT is in stored procedure
SELECT * FROM test LIMIT LIMIT1,LIMIT2;
-- SCHEMA as a function name
SELECT SCHEMA();
-- Functions
SELECT mod(3,2);SELECT * FROM TEST WHERE TB_SCHEMA = SCHEMA();
-- Group By with computed column
SELECT 1 AS col1, t1.Id FROM t1 GROUP BY col1;
-- Non Aggregate Functions
SELECT pk, LEAD(pk) OVER (ORDER BY pk) AS l;
SELECT COALESCE(LAG(last_eq.end_variation) OVER (PARTITION BY eq.account_id, eq.execution_name_id, eq.currency ORDER BY eq.start_date), 0) AS start_variation FROM t1;
