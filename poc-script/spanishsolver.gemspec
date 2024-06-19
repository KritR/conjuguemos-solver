Gem::Specification.new do |s|
  s.name        = 'SpanishSolver'
  s.version     = '0.0.1'
  s.date        = '2015-05-23'
  s.summary     = "Hola!"
  s.description = "A simple conjuguemos solver"
  s.authors     = ["Krithik Rao", "Mikel Marion"]
  s.email       = 'dontemailus@flower.com'
  s.files       = ["bin/spanishsolver.rb"]
  s.add_runtime_dependency "watir-webdriver",
  '>= 0.7.0'
  s.executables << 'spanishsolver.rb'


end