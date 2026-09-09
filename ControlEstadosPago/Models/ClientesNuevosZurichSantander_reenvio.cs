using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class ClientesNuevosZurichSantander_reenvio
{
    [StringLength(4000)]
    public string? FechaEnvio { get; set; }

    public int CodigoRamo { get; set; }

    public int CodigoCompania { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string Producto { get; set; } = null!;

    public int Plan { get; set; }

    [StringLength(4000)]
    public string? FechaOperacion { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TipoMovimiento { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Endoso { get; set; } = null!;

    [StringLength(50)]
    public string Apellido1 { get; set; } = null!;

    [StringLength(250)]
    public string? Apellido2 { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TipoDocumento { get; set; } = null!;

    public int? NumeroDocumento { get; set; }

    [StringLength(4000)]
    public string? FechaNacimiento { get; set; }

    [StringLength(10)]
    public string? Sexo { get; set; }

    [StringLength(200)]
    public string? EmailAsegurado { get; set; }

    public int CodigoActividad { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string CodigoMoneda { get; set; } = null!;

    public int SumaAsegurada { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TipoDebito { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NumeroDebito { get; set; } = null!;

    public int CodigoSucursalEmision { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string MontoPremio { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string MontoPrima { get; set; } = null!;

    [StringLength(4)]
    [Unicode(false)]
    public string MontoImpuesto1 { get; set; } = null!;

    public int MontoImpuesto2 { get; set; }

    public int NumeroCuotasPoliza { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BeobTpDocBenef1 { get; set; } = null!;

    public int BeobNuDocBenef1 { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string BeobNmBenef1 { get; set; } = null!;

    public int BeobPoPartBenef1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BebCdParentescoBenef1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_TP_DOC_BENEF2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_DOC_BENEF2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NM_BENEF2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_PO_PART_BENEF2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_PARENTESCO_BENEF2 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_TP_DOC_BENEF3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_DOC_BENEF3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NM_BENEF3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_PO_PART_BENEF3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_PARENTESCO_BENEF3 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_TP_DOC_BENEF4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_DOC_BENEF4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NM_BENEF4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_PO_PART_BENEF4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_PARENTESCO_BENEF4 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_TP_DOC_BENEF5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_DOC_BENEF5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NM_BENEF5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_PO_PART_BENEF5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_PARENTESCO_BENEF5 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_ANULACION { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_FE_VIG_ANUL { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_MT_DEVOLUCION { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_POLIZA_REF { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NU_CERTIF_REF { get; set; } = null!;

    [StringLength(4000)]
    public string? FechaVigenciaDesde { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string FechaVigenciaHasta { get; set; } = null!;

    public int CodigoSucursalEmisionCia { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_CD_USR_EMISION_CIA { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BEOB_NM_USR_EMISION_CIA { get; set; } = null!;

    public int CodigoProvinciaCia { get; set; }

    [StringLength(200)]
    public string Localidad { get; set; } = null!;

    [StringLength(250)]
    public string? Direccion { get; set; }

    public int CodigoPostal { get; set; }

    [StringLength(25)]
    public string TELEFONO1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TELEFONO2 { get; set; } = null!;

    public int NUMEROSOLICITUD { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string TPPRESTAMO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NUSUCPRESTAMO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NUPRESTAMO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string FEINIPTMO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string FEFINPTMO { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NUCUOTASPTMO { get; set; } = null!;

    public int CDDEPARTAMENTOBIEN { get; set; }

    [StringLength(200)]
    public string DELOCALIDADBIEN { get; set; } = null!;

    [StringLength(250)]
    public string? DEDIRECCIONBIEN { get; set; }

    public int CDPOSTALBIEN { get; set; }

    public int IdCRM { get; set; }
}
