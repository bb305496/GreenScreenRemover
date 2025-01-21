.code
MyProc1 proc
	;Kopjujemy orginalny kolor do r8
	mov r8, rcx

	;Kolor czerwony
	shr r8, 16
	and r8, 255
	
	;Kolor zielony
	mov r9, rcx
	shr r9, 8
	and r9, 255

	;Kolor niebieski
	mov r10, rcx
	and r10, 255

	add r8, r10
	
	mov r11, 255
	sub r11, r9

	mov r12, 50
	cmp r11, r12
	JL remove_color

	cmp r8, r9
	JGE keep_color


remove_color:
	; Jakoœ usun¹æ zielony ale jak to nie wiem
	xor rcx, rcx
	mov rax, rcx
	ret

keep_color:
	mov rax, rcx
	ret
	

MyProc1 endp

end