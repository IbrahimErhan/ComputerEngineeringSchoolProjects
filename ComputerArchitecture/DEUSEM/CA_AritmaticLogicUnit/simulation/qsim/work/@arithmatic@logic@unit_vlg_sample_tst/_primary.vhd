library verilog;
use verilog.vl_types.all;
entity ArithmaticLogicUnit_vlg_sample_tst is
    port(
        AC              : in     vl_logic_vector(3 downto 0);
        ALU_X           : in     vl_logic_vector(3 downto 0);
        \BUS\           : in     vl_logic_vector(3 downto 0);
        CLK             : in     vl_logic;
        DR              : in     vl_logic_vector(3 downto 0);
        INPR            : in     vl_logic_vector(3 downto 0);
        sampler_tx      : out    vl_logic
    );
end ArithmaticLogicUnit_vlg_sample_tst;
