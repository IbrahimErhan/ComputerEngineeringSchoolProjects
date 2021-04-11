onerror {quit -f}
vlib work
vlog -work work ArithmaticLogicUnit.vo
vlog -work work ArithmaticLogicUnit.vt
vsim -novopt -c -t 1ps -L cycloneiii_ver -L altera_ver -L altera_mf_ver -L 220model_ver -L sgate work.ArithmaticLogicUnit_vlg_vec_tst
vcd file -direction ArithmaticLogicUnit.msim.vcd
vcd add -internal ArithmaticLogicUnit_vlg_vec_tst/*
vcd add -internal ArithmaticLogicUnit_vlg_vec_tst/i1/*
add wave /*
run -all
