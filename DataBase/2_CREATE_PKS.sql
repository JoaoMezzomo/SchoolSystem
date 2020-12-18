/* ================ CREATE PKS ================ */


/* === TABELA CAD_PERFIS === */

ALTER TABLE CAD_PERFIS ADD CONSTRAINT PK_CAD_PERFIS PRIMARY KEY (IDPERFIL);

GO

/* === TABELA CAD_ALUNOS === */

ALTER TABLE CAD_ALUNOS ADD CONSTRAINT PK_CAD_ALUNOS PRIMARY KEY (IDALUNO);

GO

/* === TABELA CAD_PROFESSORES === */

ALTER TABLE CAD_PROFESSORES ADD CONSTRAINT PK_CAD_PROFESSORES PRIMARY KEY (IDPROFESSOR);

GO

/* === TABELA CAD_SERIES === */

ALTER TABLE CAD_SERIES ADD CONSTRAINT PK_CAD_SERIES PRIMARY KEY (IDSERIE);

GO

/* === TABELA CAD_TURNOS === */

ALTER TABLE CAD_TURNOS ADD CONSTRAINT PK_CAD_TURNOS PRIMARY KEY (IDTURNO);

GO

/* === TABELA CAD_TURMAS === */

ALTER TABLE CAD_TURMAS ADD CONSTRAINT PK_CAD_TURMAS PRIMARY KEY (IDTURMA);

GO

/* === TABELA CAD_DISCIPLINAS === */

ALTER TABLE CAD_DISCIPLINAS ADD CONSTRAINT PK_CAD_DISCIPLINAS PRIMARY KEY (IDDISCIPLINA);

GO

/* === TABELA CAD_PERMISSOES === */

ALTER TABLE CAD_PERMISSOES ADD CONSTRAINT PK_CAD_PERMISSOES PRIMARY KEY (IDPERMISSAO);

GO

/* === TABELA CAD_PERIODOS === */

ALTER TABLE CAD_PERIODOS ADD CONSTRAINT PK_CAD_PERIODOS PRIMARY KEY (IDPERIODO);

GO

/* === TABELA CAD_NOTAS === */

ALTER TABLE CAD_NOTAS ADD CONSTRAINT PK_CAD_NOTAS PRIMARY KEY (IDNOTA);

GO

/* === TABELA REL_TURMAS__DISCIPLINAS === */

ALTER TABLE REL_TURMAS__DISCIPLINAS ADD CONSTRAINT PK_REL_TURMAS__DISCIPLINAS PRIMARY KEY (IDTURMASDISCIPLINAS);

GO