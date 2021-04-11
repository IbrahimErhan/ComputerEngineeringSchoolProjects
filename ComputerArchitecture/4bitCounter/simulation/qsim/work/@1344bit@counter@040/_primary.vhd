library verilog;
use verilog.vl_types.all;
entity \4bitCounter\ is
    port(
        Q0              : out    vl_logic;
        VCC             : in     vl_logic;
        D0              : in     vl_logic;
        Load            : in     vl_logic;
        Count           : in     vl_logic;
        Clock           : in     vl_logic;
        Q1              : out    vl_logic;
        D1              : in     vl_logic;
        Q2              : out    vl_logic;
        D2              : in     vl_logic;
        Q3              : out    vl_logic;
        D3              : in     vl_logic;
        CarryOutputCO   : out    vl_logic
    );
end \4bitCounter\;
