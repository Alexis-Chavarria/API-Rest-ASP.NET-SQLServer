CREATE TABLE Candidatos
(
    id NVARCHAR(255),
    tipo_Documento NVARCHAR(255) NOT NULL,
    num_Documento_Estudiante NVARCHAR(255) NOT NULL,
    cedula_Ciudadania NVARCHAR(255),
    observacion_Cedula_Ciudadania NVARCHAR(255),
    diploma_Bachiller NVARCHAR(255),
    observaciones_Diploma_Bachiller NVARCHAR(255),
    acta_Bachiller NVARCHAR(255),
    observaciones_Acta_Bachiller NVARCHAR(255),
    examen_Icfes_11 NVARCHAR(255),
    observaciones_Examen_Icfes_11 NVARCHAR(255),
    diploma_Tecnico NVARCHAR(255),
    observaciones_Diploma_Tecnico NVARCHAR(255),
    acta_Tecnico NVARCHAR(255),
    observaciones_Acta_Tecnico NVARCHAR(255),
    resultado_TyT_Tecnico NVARCHAR(255),
    observaciones_Resultado_TyT_Tecnico NVARCHAR(255),
    observaciones_Diploma_Tecnologo NVARCHAR(255),
    acta_Tecnologo NVARCHAR(255),
    observaciones_Acta_Tecnologo NVARCHAR(255),
    resultado_TyT_Tecnologo NVARCHAR(255),
    observaciones_Resultado_TyT_Tecnologo NVARCHAR(255),
    diploma_Profesional NVARCHAR(255),
    observaciones_Diploma_Profesional NVARCHAR(255),
    acta_Profesional NVARCHAR(255),
    observaciones_Acta_Profesional NVARCHAR(255),
    resultado_Saber_Pro NVARCHAR(255),
    observaciones_Resultado_Saber_Pro NVARCHAR(255),
    estado_Final_estudiante NVARCHAR(255),
    fecha_Revision_Bot NVARCHAR(255)
);

SELECT * FROM Candidatos;
DELETE FROM Candidatos;

DROP TABLE GRADOS_APP.dbo.Candidatos;

