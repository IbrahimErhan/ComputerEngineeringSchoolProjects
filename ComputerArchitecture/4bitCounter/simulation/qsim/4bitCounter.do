onerror {quit -f}
vlib work
vlog -work work 4bitCounter.vo
vlog -work work 4bitCounter.vt
vsim -novopt -c -t 1ps -L cycloneiii_ver -L altera_ver -L altera_mf_ver -L 220model_ver -L sgate work.4bitCounter_vlg_vec_tst
vcd file -direction 4bitCounter.msim.vcd
vcd add -internal 4bitCounter_vlg_vec_tst/*
vcd add -internal 4bitCounter_vlg_vec_tst/i1/*
add wave /*
run -all
