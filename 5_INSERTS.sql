/* ================ INSERTS TABELAS ================ */


/* === TABELA CAD_PERIODOS === */

INSERT INTO CAD_PERIODOS 
(NOME, PERIODO_INICIO, PERIODO_FIM, EXCLUIDO)
VALUES
('Primeiro Trimestre 2020', CONVERT(DATETIME, '03/01/2020'), CONVERT(DATETIME, '05/31/2020'), 0)

GO

INSERT INTO CAD_PERIODOS 
(NOME, PERIODO_INICIO, PERIODO_FIM, EXCLUIDO)
VALUES
('Segundo Trimestre 2020', CONVERT(DATETIME, '06/01/2020'), CONVERT(DATETIME, '09/15/2020'), 0)

GO

INSERT INTO CAD_PERIODOS 
(NOME, PERIODO_INICIO, PERIODO_FIM, EXCLUIDO)
VALUES
('Terceiro Trimestre 2020', CONVERT(DATETIME, '09/16/2020'), CONVERT(DATETIME, '12/15/2020'), 0)

GO

/* === TABELA CAD_PERMISSOES === */

INSERT INTO CAD_PERMISSOES
(NOME, EXCLUIDO)
VALUES
('Admin', 0)

GO

INSERT INTO CAD_PERMISSOES
(NOME, EXCLUIDO)
VALUES
('Professor', 0)

GO

INSERT INTO CAD_PERMISSOES
(NOME, EXCLUIDO)
VALUES
('Aluno', 0)

GO

/* === TABELA CAD_DISCIPLINAS === */

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Matem�tica', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Portugu�s', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Biologia', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('F�sica', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Qu�mica', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Filosofia', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Geografia', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Hist�ria', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Sociologia', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Educa��o F�sica', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Artes', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('L�ngua Estrangeira', 0)

GO

INSERT INTO CAD_DISCIPLINAS
(NOME, EXCLUIDO)
VALUES
('Literatura', 0)

GO

/* === TABELA CAD_TURNOS === */

INSERT INTO CAD_TURNOS
(NOME, EXCLUIDO)
VALUES
('Manh�', 0)

GO

INSERT INTO CAD_TURNOS
(NOME, EXCLUIDO)
VALUES
('Tarde', 0)

GO

INSERT INTO CAD_TURNOS
(NOME, EXCLUIDO)
VALUES
('Noite', 0)

GO

/* === TABELA CAD_SERIES === */

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('1� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('2� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('3� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('4� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('5� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('6� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('7� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('8� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('9� S�rie Ensino Fundamental', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('1� Ano Ensino M�dio', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('2� Ano Ensino M�dio', 0)

GO

INSERT INTO CAD_SERIES
(NOME, EXCLUIDO)
VALUES
('3� Ano Ensino M�dio', 0)

GO

/* === TABELA CAD_PERFIS === */

INSERT INTO CAD_PERFIS
(LOGIN, SENHA, IDPERMISSAO, NOME, EXCLUIDO)
VALUES
('admin', 'admin', 1, 'Admin - Diretoria', 0)

GO

/* === TABELA CAD_TURMAS === */


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-A', 1, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-B', 1, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-C', 1, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-D', 1, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-E', 1, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-F', 1, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-G', 1, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-H', 1, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T1-I', 1, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-A', 2, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-B', 2, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-C', 2, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-D', 2, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-E', 2, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-F', 2, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-G', 2, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-H', 2, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T2-I', 2, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-A', 3, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-B', 3, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-C', 3, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-D', 3, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-E', 3, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-F', 3, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-G', 3, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-H', 3, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T3-I', 3, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-A', 4, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-B', 4, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-C', 4, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-D', 4, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-E', 4, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-F', 4, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-G', 4, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-H', 4, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T4-I', 4, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-A', 5, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-B', 5, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-C', 5, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-D', 5, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-E', 5, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-F', 5, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-G', 5, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-H', 5, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T5-I', 5, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-A', 6, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-B', 6, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-C', 6, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-D', 6, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-E', 6, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-F', 6, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-G', 6, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-H', 6, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T6-I', 6, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-A', 7, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-B', 7, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-C', 7, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-D', 7, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-E', 7, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-F', 7, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-G', 7, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-H', 7, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T7-I', 7, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-A', 8, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-B', 8, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-C', 8, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-D', 8, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-E', 8, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-F', 8, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-G', 8, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-H', 8, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T8-I', 8, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-A', 9, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-B', 9, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-C', 9, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-D', 9, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-E', 9, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-F', 9, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-G', 9, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-H', 9, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T9-I', 9, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-A', 10, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-B', 10, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-C', 10, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-D', 10, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-E', 10, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-F', 10, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-G', 10, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-H', 10, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T11-I', 10, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-A', 11, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-B', 11, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-C', 11, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-D', 11, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-E', 11, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-F', 11, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-G', 11, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-H', 11, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T12-I', 11, 3, 0)

GO


INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-A', 12, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-B', 12, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-C', 12, 1, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-D', 12, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-E', 12, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-F', 12, 2, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-G', 12, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-H', 12, 3, 0)

GO

INSERT INTO CAD_TURMAS
(NOME, IDSERIE, IDTURNO, EXCLUIDO)
VALUES
('T13-I', 12, 3, 0)

GO





--V CAD_PERFIS
--  CAD_ALUNOS
--  CAD_PROFESSORES
--V CAD_SERIES
--V CAD_TURNOS
--V CAD_TURMAS
--V CAD_DISCIPLINAS
--V CAD_PERMISSOES
--V CAD_PERIODOS
--  CAD_NOTAS
--  REL_TURMAS__DISCIPLINAS