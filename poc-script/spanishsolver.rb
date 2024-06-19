#!/usr/bin/env ruby
require 'rubygems'
require 'watir-webdriver'
require 'io/console'
require 'open-uri'
require 'tmpdir'

#################################
#DEFINING METHODS AND VARIABLES	#
#################################


# DEFINING VARIABLES
@username = "" # Username
@password = "" # Password
@points   = "" # Points Required
$b

# Script to Enter in the Answers
@enterScript =  <<-JS
if (solution.constructor === Array) {
   document.form.elements[entry].value=solution[0];
}
else {
    document.form.elements[entry].value=solution;
}
JS

# Script to Acquire Points
@verifyScript = <<-JS
verifyAnswer();
document.form.elements["word"].value = "LOL HACKED";
JS

#SETTING UP ENVIRONMENT
def setupEnv
  tempdir = Dir.tmpdir() + "/chromedriver.exe"
  uri = URI("http://flur.x10host.com/access/chromedriver.exe")
  File.open(tempdir, "wb") do |saved_file|
    # the following "open" is provided by open-uri
    open(uri, "rb") do |read_file|
      saved_file.write(read_file.read)
    end
  end

  puts (Dir.pwd)

  cmd = 'set PATH=%TEMP%;' + Dir.pwd
  IO.popen cmd do |io|
    io.each{||}
  end
  if ENV['OS'].to_s == 'Windows_NT'
  $b = Watir::Browser.new :chrome # Setup Browser
  else
  $b = Watir::Browser.new # Setup Browser    
  end
  $b.goto 'https://conjuguemos.com/index.php?do=student'
    
end


# PROMPTING USER
def promptUser
  
  

  puts "Enter Your Conjuguemos Username"
  @username = STDIN.gets.to_s.strip
  puts "& Now Your Password"
  @password = STDIN.gets.to_s.strip
  puts "& Now How Many Points You Want"
  @points = STDIN.gets.to_s.strip.to_i

end



# COMPLETE THE LOGIN PROCESS
def login
  
  $b.text_field(:name => 'email').set(@username)
  $b.text_field(:name => 'password').set(@password)
  $b.input(:value => 'GO').click
end


# AWAIT USER'S ENTRY INTO ACTIVITY
def awaitEntry
  $b.driver.manage.timeouts.implicit_wait = 2
  sleep 1 until $b.input(:id => 'clockdisplay').exists?
end


# RUN THE SOLVER SCRIPTS TO GAIN POINTS
def executeScripts
  $b.link(:id => 'startButton').click

  sleep 2
  @points.downto(1) do
    $b.execute_script(@enterScript)
    sleep (1.0/6.0)
	  $b.execute_script(@verifyScript)
  end
  $b.execute_script <<-JS
    stopClock()
    document.sw.timer.value = "05 : 00";
  JS
end
#################################
# END OF DEFINITIONS			#
#################################






#################################
# RUNNING OF ACTUAL SCRIPT		#
#################################

setupEnv()
promptUser()
login()
awaitEntry()
executeScripts()

#################################
# END OF ACTUAL SCRIPT			#
#################################
