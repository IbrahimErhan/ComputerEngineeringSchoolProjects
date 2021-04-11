library verilog;
use verilog.vl_types.all;
entity ArithmaticLogicUnit is
    port(
        E               : out    vl_logic;
        AC              : in     vl_logic_vector(3 downto 0);
        DR              : in     vl_logic_vector(3 downto 0);
        Output          : out    vl_logic_vector(3 downto 0);
        CLK             : in     vl_logic;
        \BUS\           : in     vl_logic_vector(3 downto 0);
        INPR            : in     vl_logic_vector(3 downto 0);
        ALU_X           : in     vl_logic_vector(3 downto 0)
    );
end ArithmaticLogicUnit;
