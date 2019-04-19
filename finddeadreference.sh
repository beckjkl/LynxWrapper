filelist=$(ls -alhR | grep -v "^$" | grep -v "^total" | grep -v "^d" | tr -s ' ' | sed "s/://g" | sed "s/ /%/g")
looklist=""
prefix=""
suffix=""
for file in $filelist; do
	if ! [[ -z $(echo $file | grep "^\." ) ]] ; then
		prefix=$(echo "$file/")
#		echo $prefix
	else
		suffix=$(echo $file | cut -d '%' -f9)
	 	looklist=$(echo "${looklist}$prefix$suffix\\n")
	fi
done
for line in $(echo -e "$looklist"); do
	if ! [[ -z $(cat $line | grep -H "TempBackupPath") ]] ; then 
		echo $line
	         grep -Hnn "TempBackupPath" $line
	fi
done
